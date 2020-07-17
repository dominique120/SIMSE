using BE.AUTH;
using BL.AUTH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.AUTH {
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        }

        int tries = 0;

        private void Login_Load(object sender, EventArgs e) {
            AuthBL abl = new AuthBL();
            if (abl.IsAvailable() == true) {
                return;
            } else {
                MessageBox.Show(this, "No hay conexión a la base de datos. Comuníquese con el encargado de IT", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }
    
        private void btnIngresar_Click(object sender, EventArgs e) {
            AuthBL authBL = new AuthBL();
            AuthBE authBE = new AuthBE(txtUser.Text.Trim(), txtPassword.Text.Trim());
            tries += 1;
            try {
                if (authBL.Authenticate(authBE) == true) {
                    frmMain frmmain = new frmMain();
                    frmLogin frmlogin = new frmLogin();
                    frmmain.Show();
                    this.Hide();
                    //frmlogin.Close();
                } else {
                    MessageBox.Show(this, "Error de autenticación ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } catch (Exception ex){
                if (tries == 3) {
                    MessageBox.Show(this, "Ya no tiene mas intentos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                MessageBox.Show(this, "Error de autenticación: "+ ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                btnIngresar.PerformClick();
            }
        }
    }
}
