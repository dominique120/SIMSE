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
    public partial class listarPlano : System.Web.UI.Page
    {
        ProyectoBL prBL = new ProyectoBL();
        PlanosBL plBL = new PlanosBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                if (Page.IsPostBack == false) {
                    cboProyecto.DataSource = prBL.ListarProyectos();
                    cboProyecto.DataTextField = "Nombre";
                    cboProyecto.DataValueField = "ID Proyecto";
                    cboProyecto.DataBind();

                    cboTipoPlano.DataSource = plBL.ListarTiposDePlano();
                    cboTipoPlano.DataTextField = "nom_tipo_plano";
                    cboTipoPlano.DataValueField = "id_tipo_plano";
                    cboTipoPlano.DataBind();
                }
            } catch (Exception ex) {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e) {
            try {
                grvPlanos.DataSource = plBL.ListarPlanosPorProyectoTipo(
                        int.Parse(cboProyecto.SelectedValue.ToString()), 
                        int.Parse(cboTipoPlano.SelectedValue.ToString()));
                grvPlanos.DataBind();
                lblMensaje.Text = "Documentos Encontrados: " + grvPlanos.Rows.Count.ToString();
            } catch (Exception ex) {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}