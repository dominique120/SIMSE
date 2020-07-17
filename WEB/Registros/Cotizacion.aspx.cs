using BE.DOCUMENTO;
using BL.Documento;
using BL.Inventario;
using BL.Persona;
using BL.Proyecto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB.Registros
{
    public partial class OrdenCompra : System.Web.UI.Page
    {

        ProyectoBL proBL = new ProyectoBL();
        EmpleadoBL empBL = new EmpleadoBL();
        ArticuloBL aBL = new ArticuloBL();
        ClienteBL cBL = new ClienteBL();

        DataTable detalles;
        DataColumn id_cotizacion;
        DataColumn id_detalle_cotizacion;
        DataColumn id_item;
        DataColumn precio;
        DataColumn cantidad;
        DataColumn descuento;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false) {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");

                try {
                    ProyectoBL pBL = new ProyectoBL();
                    cboProyecto.DataSource = pBL.ListarProyectos();
                    cboProyecto.DataTextField = "Nombre";
                    cboProyecto.DataValueField = "ID Proyecto";
                    cboProyecto.DataBind();
                } catch (Exception ex) {
                    lblMensaje.Text = "Error al poblar opciones de proyecto : " + ex.Message;
                    mpeMensaje.Show();
                }

                try {
                    EmpleadoBL eBL = new EmpleadoBL();
                    cboEncargado.DataSource = eBL.ListarEmpleadosFull();
                    cboEncargado.DataTextField = "Nombre Completo";
                    cboEncargado.DataValueField = "ID Empleado";
                    cboEncargado.DataBind();
                } catch (Exception ex) {
                    lblMensaje.Text = "Error al poblar opciones de persona : " + ex.Message;
                    mpeMensaje.Show();
                }

                try {
                    EmpleadoBL eBL = new EmpleadoBL();
                    cboAprobadoPor.DataSource = eBL.ListarEmpleadosFull();
                    cboAprobadoPor.DataTextField = "Nombre Completo";
                    cboAprobadoPor.DataValueField = "ID Empleado";
                    cboAprobadoPor.DataBind();
                } catch (Exception ex) {
                    lblMensaje.Text = "Error al poblar opciones de persona : " + ex.Message;
                    mpeMensaje.Show();
                }

                try {
                    ClienteBL clBL = new ClienteBL();
                    cboEnviar.DataSource = clBL.ListarClientesFull();
                    cboEnviar.DataTextField = "Nombre Cliente";
                    cboEnviar.DataValueField = "ID Persona";
                    cboEnviar.DataBind();
                } catch (Exception ex) {
                    lblMensaje.Text = "Error al poblar opciones de persona : " + ex.Message;
                    mpeMensaje.Show();
                }

                try {
                    ArticuloBL eBL = new ArticuloBL();
                    cboProducto.DataSource = eBL.ListarArticulos();
                    cboProducto.DataTextField = "nom_articulo";
                    cboProducto.DataValueField = "id_item";
                    cboProducto.DataBind();
                } catch (Exception ex) {
                    lblMensaje.Text = "Error al poblar opciones de producto : " + ex.Message;
                    mpeMensaje.Show();
                }
                CrearTabla();
            }
        }

        protected void grDetalles_RowCommand(object sender, GridViewCommandEventArgs e) {
            try {
                // Obtenemos el indice de la fila seleccionada
                int indicefila = Convert.ToInt16(e.CommandArgument);

                // Si se pulso en el boton eliminar , eliminamos el detalle de memoria
                if (e.CommandName == "Eliminar") {
                    detalles = (DataTable)Session["Detalles"];
                    detalles.Rows.RemoveAt(indicefila);
                    grDetalles.DataSource = detalles;
                    grDetalles.DataBind();
                    Session["Detalles"] = detalles;
                }

            } catch (Exception ex) {
                lblMensajeDetalle.Text = "Error :" + ex.Message;
                PopDetalle.Show();
            }
        }

        private void CrearTabla() {
            detalles = new DataTable("DOCUMENTO.DetalleCotizacion");

            //Creando las columnas para la tabla temporal de  detalle de compra
            //Columna Codigo
            DataColumn id_cotizacion = new DataColumn("id_cotizacion");
            id_cotizacion.DataType = Type.GetType("System.Int16");
            detalles.Columns.Add(id_cotizacion);

            DataColumn id_detalle_cotizacion = new DataColumn("id_detalle_cotizacion");
            id_detalle_cotizacion.DataType = Type.GetType("System.Guid");
            detalles.Columns.Add(id_detalle_cotizacion);

            DataColumn id_item = new DataColumn("id_item");
            id_item.DataType = Type.GetType("System.Int16");
            detalles.Columns.Add(id_item);

            DataColumn cantidad = new DataColumn("cantidad");
            cantidad.DataType = Type.GetType("System.Int16");
            detalles.Columns.Add(cantidad);

            DataColumn descuento = new DataColumn("descuento");
            descuento.DataType = Type.GetType("System.Double");
            detalles.Columns.Add(descuento);


            //definimos la PK
            detalles.PrimaryKey = new DataColumn[] { detalles.Columns["id_detalle_lista"] };
            grDetalles.DataSource = detalles;
            grDetalles.DataBind();
            Session["Detalles"] = detalles;

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            cboProducto.SelectedIndex = 0;
            txtCantidad.Text = String.Empty;
            txtDescuento.Text = String.Empty;
            lblMensajeDetalle.Text = String.Empty;
            PopDetalle.Show();
        }

        protected void btnCancelarDetalle_Click(object sender, EventArgs e) {
            mpeMensaje.Hide();
            PopDetalle.Hide();
        }

        protected void btnGrabarCotizacion_Click(object sender, EventArgs e)
        {
            try {
                detalles = (DataTable)Session["Detalles"];

                // Validamos las fechas...
                if (dtpAprobacion.Text == "") {
                    throw new Exception("Debe ingresar fecha de aprobacion.");
                }

                if (dtpCreacion.Text == "") {
                    throw new Exception("Debe ingresar fecha de creacion.");
                }


                // Si existen  registros de detalles se registra la orden
                if (detalles.Rows.Count > 0) {
                    CotizacionBE cotBE = new CotizacionBE();
                    CotizacionBL cotBL = new CotizacionBL();

                    //Asignamos valores de cabecera ( El nro lo genera el SP)
                    cotBE.Id_aprobado_por = Convert.ToInt32(cboAprobadoPor.SelectedValue);
                    cotBE.Id_proyecto = Convert.ToInt32(cboProyecto.SelectedValue);
                    cotBE.Id_encargado = Convert.ToInt32(cboEncargado.SelectedValue);
                    cotBE.Enviar_a = Convert.ToInt32(cboEnviar.SelectedValue);

                    cotBE.Fecha_aprobacion = Convert.ToDateTime(dtpAprobacion.Text);
                    cotBE.Fecha_creacion = Convert.ToDateTime(dtpCreacion.Text);
                    cotBE.Fecha_envio = Convert.ToDateTime(dtpEnvio.Text);

                    cotBE.Path_archivo = txtPath.Text;
                    cotBE.Notas = txtNotas.Text;

                    // Asignamos los detalles a la propiedad respectiva
                    cotBE.DetalleDeCotizacion = detalles;

                    // Se evalua el exito del metodo
                    int rnid = cotBL.CotizacionConDetallesNew(cotBE);
                    if (rnid == -1) {
                        throw new Exception("Error , no se registró la orden. Contacte con IT.");
                    } else {
                        lblMensaje.Text = "Se registró la orden Nro: " + rnid.ToString() + " exitosamente.";
                        mpeMensaje.Show();
                        // Reinicio los controles y  la tabla por si se desea registrar una nueva orden de compra
                        dtpAprobacion.Text = "";
                        dtpCreacion.Text = "";
                        dtpEnvio.Text = "";
                        txtNotas.Text = "";
                        txtPath.Text = "";
                        cboAprobadoPor.SelectedIndex = 0;
                        cboProyecto.SelectedIndex = 0;
                        cboEncargado.SelectedIndex = 0;
                        cboEnviar.SelectedIndex = 0;
                        CrearTabla();

                    }
                }
                //Si no hay detalles, no se puede registrar la  orden 
                else {
                    throw new Exception("No puede registrar una orden sin detalles.");
                }
            } catch (Exception ex) {
                lblMensaje.Text = ex.Message;
                mpeMensaje.Show();
            }
        }

        protected void btnGrabarDetalle_Click(object sender, EventArgs e) {
            try {
                if (txtCantidad.Text == "") {
                    throw new Exception("Debe ingresar una cantidad");
                }

                detalles = (DataTable)Session["Detalles"];

                DataRow dr;
                dr = detalles.NewRow();

                //dr["id_lista"] = cboProducto.SelectedValue.ToString();
                dr["id_detalle_cotizacion"] = Guid.NewGuid();
                //dr["nombre"] = cboProducto.SelectedValue.ToString();
                dr["id_item"] = Convert.ToInt16(cboProducto.SelectedValue);
                dr["cantidad"] = Convert.ToInt16(txtCantidad.Text);
                dr["descuento"] = Convert.ToInt16(txtDescuento.Text);

                detalles.Rows.Add(dr);

                grDetalles.DataSource = detalles;
                grDetalles.DataBind();
            } catch (Exception ex) {
                lblMensajeDetalle.Text = "Error: " + ex.Message;
                PopDetalle.Show();
            }
        }

    }
}