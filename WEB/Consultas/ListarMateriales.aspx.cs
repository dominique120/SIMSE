using BL.Documento;
using BL.Proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB.Consultas
{
    public partial class ListarMateriales : System.Web.UI.Page
    {
        ProyectoBL prBL = new ProyectoBL();
        ListaDeMaterialesBL lmatBL = new ListaDeMaterialesBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                if (Page.IsPostBack == false) {
                    cboProyecto.DataSource = prBL.ListarProyectos();
                    cboProyecto.DataTextField = "Nombre";
                    cboProyecto.DataValueField = "ID Proyecto";
                    cboProyecto.DataBind();
                }
            } catch (Exception ex) {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e) {
            try {
                grvListas.DataSource = lmatBL.ListarMaterialesPorProyecto(int.Parse(cboProyecto.SelectedValue.ToString()));
                grvListas.DataBind();
                lblMensaje.Text = "Documentos Encontrados: " + grvListas.Rows.Count.ToString();
            } catch (Exception ex) {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}