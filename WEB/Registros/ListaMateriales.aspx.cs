using BE.DOCUMENTO;
using BE.PERSONA;
using BL.Documento;
using BL.Inventario;
using BL.Persona;
using BL.Proyecto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB.Registros {
    public partial class Materiales : System.Web.UI.Page {

        ProyectoBL proBL = new ProyectoBL();
        EmpleadoBL empBL = new EmpleadoBL();
        ArticuloBL aBL = new ArticuloBL();

        DataTable detalles;
        DataColumn id_detalle_lista;
        DataColumn id_lista;
        DataColumn cantidad;
        DataColumn id_item;

        protected void Page_Load(object sender, EventArgs e) {

            if (Page.IsPostBack == false) {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");

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
                    cboAprobado.DataSource = eBL.ListarEmpleadosFull();
                    cboAprobado.DataTextField = "Nombre Completo";
                    cboAprobado.DataValueField = "ID Empleado";
                    cboAprobado.DataBind();
                } catch (Exception ex) {
                    lblMensaje.Text = "Error al poblar opciones de persona : " + ex.Message;
                    mpeMensaje.Show();
                }

                try {
                    EmpleadoBL eBL = new EmpleadoBL();
                    cboIngresadoPor.DataSource = eBL.ListarEmpleadosFull();
                    cboIngresadoPor.DataTextField = "Nombre Completo";
                    cboIngresadoPor.DataValueField = "ID Empleado";
                    cboIngresadoPor.DataBind();
                } catch (Exception ex) {
                    lblMensaje.Text = "Error al poblar opciones de persona : " + ex.Message;
                    mpeMensaje.Show();
                }

                try {
                    EmpleadoBL eBL = new EmpleadoBL();
                    cboPedidoPor.DataSource = eBL.ListarEmpleadosFull();
                    cboPedidoPor.DataTextField = "Nombre Completo";
                    cboPedidoPor.DataValueField = "ID Empleado";
                    cboPedidoPor.DataBind();
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
            detalles = new DataTable("DOCUMENTO.DetalleListaMateriales");

            //Creando las columnas para la tabla temporal de  detalle de compra
            //Columna Codigo
            DataColumn id_lista = new DataColumn("id_lista");
            id_lista.DataType = Type.GetType("System.Int16");
            detalles.Columns.Add(id_lista);

            DataColumn id_detalle_lista = new DataColumn("id_detalle_lista");
            id_detalle_lista.DataType = Type.GetType("System.Guid");
            detalles.Columns.Add(id_detalle_lista);

            DataColumn id_item = new DataColumn("id_item");
            id_item.DataType = Type.GetType("System.Int16");
            detalles.Columns.Add(id_item);

            DataColumn cantidad = new DataColumn("cantidad");
            cantidad.DataType = Type.GetType("System.Int16");
            detalles.Columns.Add(cantidad);


            //definimos la PK
            detalles.PrimaryKey = new DataColumn[] { detalles.Columns["id_detalle_lista"] };
            grDetalles.DataSource = detalles;
            grDetalles.DataBind();
            Session["Detalles"] = detalles;

        }

        protected void btnAgregar_Click(object sender, EventArgs e) {
            cboProducto.SelectedIndex = 0;
            txtCantidad.Text = String.Empty;
            lblMensajeDetalle.Text = String.Empty;
            PopDetalle.Show();
        }

        protected void btnGrabar_Click(object sender, EventArgs e) {
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
                    ListaDeMaterialesBE lmatBE = new ListaDeMaterialesBE();
                    ListaDeMaterialesBL lmatBL = new ListaDeMaterialesBL();

                    //Asignamos valores de cabecera ( El nro lo genera el SP)
                    lmatBE.Aprobado_por = Convert.ToInt32(cboAprobado.SelectedValue);
                    lmatBE.Proyecto = Convert.ToInt32(cboProyecto.SelectedValue);
                    lmatBE.Pedido_por = Convert.ToInt32(cboPedidoPor.SelectedValue);
                    lmatBE.Fecha_aprobada = Convert.ToDateTime(dtpAprobacion.Text);
                    lmatBE.Fecha_pedida = Convert.ToDateTime(dtpCreacion.Text);
                    lmatBE.Ingresado_por = Convert.ToInt32(cboIngresadoPor.SelectedValue);
                    lmatBE.Aprobado = false;

                    // Asignamos los detalles a la propiedad respectiva
                    lmatBE.DetalleDeListaMateriales = detalles;

                    // Se evalua el exito del metodo
                    int rnid = lmatBL.ListaMaterialesConDetallesNew(lmatBE);
                    if (rnid == -1) {
                        throw new Exception("Error , no se registró la orden. Contacte con IT.");
                    } else {
                        lblMensaje.Text = "Se registró la orden Nro: " + rnid.ToString() + " exitosamente.";
                        mpeMensaje.Show();
                        // Reinicio los controles y  la tabla por si se desea registrar una nueva orden de compra
                        dtpAprobacion.Text = "";
                        dtpCreacion.Text = "";
                        txtNotas.Text = "";
                        cboPedidoPor.SelectedIndex = 0;
                        cboProyecto.SelectedIndex = 0;
                        cboAprobado.SelectedIndex = 0;
                        cboIngresadoPor.SelectedIndex = 0;
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
                dr["id_detalle_lista"] = Guid.NewGuid();
                //dr["nombre"] = cboProducto.SelectedValue.ToString();
                dr["id_item"] = Convert.ToInt16(cboProducto.SelectedValue);
                dr["cantidad"] = Convert.ToInt16(txtCantidad.Text);

                detalles.Rows.Add(dr);

                grDetalles.DataSource = detalles;
                grDetalles.DataBind();
            } catch (Exception ex) {
                lblMensajeDetalle.Text = "Error: " + ex.Message;
                PopDetalle.Show();
            }
        }

        protected void btnCancelarDetalle_Click(object sender, EventArgs e) {
            
            PopDetalle.Hide();
        }

        protected void btnAceptar_Click(object sender, EventArgs e) {
            mpeMensaje.Hide();
            
        }


    }
}