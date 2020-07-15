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
    public partial class frmEliminarCredencial : Form {
        public frmEliminarCredencial() {
            InitializeComponent();
        }

        AuthBL authBL = new AuthBL();

        private void btnEliminar_Click(object sender, EventArgs e) {
            string usuario = txtUsuario.Text.Trim();
            
            DialogResult lt = MessageBox.Show(this, "Desea eliminar este usuario?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (lt == DialogResult.Yes) {
                if (authBL.EliminarCredencial(usuario) == true) {
                    MessageBox.Show(this, "Se elimino correctamente el usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else {
                MessageBox.Show(this, "Ocurrió un error al eliminar el usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
