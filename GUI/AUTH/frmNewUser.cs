using BE.AUTH;
using BL.AUTH;
using BL.MarketingUTIL;
using BL.Persona;
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
    public partial class frmNewUser : Form {
        public frmNewUser() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            AuthBE authBE = new AuthBE(txtUsuario.Text.Trim(), txtPwd.Text.Trim(), int.Parse(cboEmpleado.SelectedValue.ToString()), chkActivo.Checked);
            AuthBL authBL = new AuthBL();

            if (authBL.CredentialNew(authBE) == true) {
                MessageBox.Show(this, "Se agrego el usuario correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show(this, "Ocurrió un error al agregar el usuario ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmNewUser_Load(object sender, EventArgs e) {
            EmpleadoBL bL = new EmpleadoBL();
            cboEmpleado.DataSource = bL.ListarEmpleadosFull(); ;
            cboEmpleado.DisplayMember = "Nombre Completo";
            cboEmpleado.ValueMember = "ID Empleado";
        }
    }
}
