using BE.AUTH;
using BL.AUTH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB
{
    
    public partial class Login : System.Web.UI.Page
    {
        int tries = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            AuthBL abl = new AuthBL();
            if (abl.IsAvailable() == true) {
                return;
            } else {
                lblMensaje.Text = "No hay conexión a la base de datos. Comuníquese con el encargado de IT";
                btnIngresar.Enabled = false;
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            AuthBL authBL = new AuthBL();
            AuthBE authBE = new AuthBE(txtUsuario.Text.Trim(), txtPassword.Text.Trim());
            tries += 1;
            try {
                if (authBL.Authenticate(authBE) == true) {
                    Response.Redirect("Overview.aspx");
                } else {
                    lblMensaje.Text = "Credenciales incorrectas, intente nuevamente.";
                }

            } catch (Exception ex) {
                if (tries == 3) {
                    Response.Redirect("Error.aspx");
                }
                lblMensaje.Text = ex.Message;
            }
        }
    }
}