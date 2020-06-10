using BE.PERSONA;
using BL.PersonaUTIL;
using BL.UTIL;
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
    public partial class frmNewEmail : Form {
        public frmNewEmail() {
            InitializeComponent();
        }
        PersonaBL perBL = new PersonaBL();
        EmailsBL emBL = new EmailsBL();
        private void frnNewEmail_Load(object sender, EventArgs e) {
            try {
                //tipo telefono
                cboEmailTipo.DataSource = emBL.ListarEmailsTipos();
                cboEmailTipo.DisplayMember = "nombre_email";
                cboEmailTipo.ValueMember = "tipo_email";

                cboPersonas.DataSource = perBL.ListarPersonasALL();
                cboPersonas.DisplayMember = "Nombre";
                cboPersonas.ValueMember = "Id Persona";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones : " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            int idPersona = int.Parse(cboPersonas.SelectedValue.ToString());

            EmailBE emBE = new EmailBE(short.Parse(cboEmailTipo.SelectedValue.ToString()), idPersona, txtEmailEmail.Text.Trim());
            EmailsBL emBL = new EmailsBL();


            if (emBL.EmailNew(emBE) == true) {
                MessageBox.Show(this, "Se guardo correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show(this, "Ocurrió un error", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
