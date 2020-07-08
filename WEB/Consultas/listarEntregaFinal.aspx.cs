using BL.Documento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB.Consultas
{
    public partial class listarEntregaFinal : System.Web.UI.Page
    {
        EntregaFinalBL ef = new EntregaFinalBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e) {
            try {
                grvEntregas.DataSource = ef.ListarEntregasFinalesFechas(
                    Convert.ToDateTime(txtFInicio.Text), Convert.ToDateTime(txtFFIN.Text));
                grvEntregas.DataBind();
                lblMensaje.Text = "Documentos Encontrados: " + grvEntregas.Rows.Count.ToString();
            } catch (Exception ex) {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}