using BL.Documento;
using BL.Persona;
using BL.Proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB.Consultas
{
    public partial class listarReporteSupervision : System.Web.UI.Page
    {
        ProyectoBL prBL = new ProyectoBL();
        EmpleadoBL emBL = new EmpleadoBL();
        ReporteSupervisionBL rsBL = new ReporteSupervisionBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                if (Page.IsPostBack == false) {
                    cboProyecto.DataSource = prBL.ListarProyectos();
                    cboProyecto.DataTextField = "Nombre";
                    cboProyecto.DataValueField = "ID Proyecto";
                    cboProyecto.DataBind();

                    cboEmpleado.DataSource = emBL.ListarEmpleadosFull();
                    cboEmpleado.DataTextField = "Nombre Completo";
                    cboEmpleado.DataValueField = "ID Empleado";
                    cboEmpleado.DataBind();
                }
            } catch (Exception ex) {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e) {
            try {
                grvReportes.DataSource = rsBL.ListarReporteSupervisionProyectoSupervisor(
                        int.Parse(cboProyecto.SelectedValue.ToString()),
                        int.Parse(cboEmpleado.SelectedValue.ToString()));
                grvReportes.DataBind();
                lblMensaje.Text = "Documentos Encontrados: " + grvReportes.Rows.Count.ToString();
            } catch (Exception ex) {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}