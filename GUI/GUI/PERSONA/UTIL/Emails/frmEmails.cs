using BL.UTIL;
using GUI.PERSONA.UTIL.Emails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.PERSONA.UTIL.Emails {
    public partial class frmEmails : Form {
        public frmEmails() {
            InitializeComponent();
        }

        public void cargar() {
            DataTable src = email.ListarEmailsFull();
            dtgEmail.DataSource = src;
            cboPersonas.DataSource = src;
            cboPersonas.DisplayMember = "Nombre";
            cboPersonas.ValueMember = "Id Persona";
        }

        EmailsBL email = new EmailsBL();

        private void frmEmails_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int idPersona = int.Parse(cboPersonas.SelectedValue.ToString());
            dtgEmail.DataSource = email.ListarEmailsFullPorId(idPersona);
        }

        private void btnNew_Click(object sender, EventArgs e) {
            frmNewEmail ne = new frmNewEmail();
            ne.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            DialogResult lt = MessageBox.Show(this, "Desea eliminar este email?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            EmailsBL emBL = new EmailsBL();
            if (lt == DialogResult.Yes) {
                if (emBL.EliminarEmail(int.Parse(dtgEmail.CurrentRow.Cells[0].Value.ToString())) == true) {
                    MessageBox.Show(this, "Se elimino correctamente el email", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar();
                }
            } else {
                MessageBox.Show(this, "Ocurrió un error al eliminar el email", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            try {
                frmModificarEmail modem = new frmModificarEmail();
                modem.Id_email = int.Parse(dtgEmail.CurrentRow.Cells[0].Value.ToString());
                modem.ShowDialog();
                cargar();
            } catch (Exception z) {
                throw new Exception(z.Message);
            }
        }
    }
}
