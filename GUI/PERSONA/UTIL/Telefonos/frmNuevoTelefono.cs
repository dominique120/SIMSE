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

namespace GUI.PERSONA.UTIL.Telefonos {
    public partial class frmNuevoTelefono : Form {
        public frmNuevoTelefono() {
            InitializeComponent();
        }

        TelefonosBL tels = new TelefonosBL();
        PersonaBL perBL = new PersonaBL();

        private void OnlyNumbers(object sender, KeyPressEventArgs e) {
            if (e.KeyChar != 8) {
                if (char.IsDigit(e.KeyChar) == false) {
                    e.Handled = true;
                }
            }
        }

        private void frmNuevoTelefono_Load(object sender, EventArgs e) {
            try {
                //tipo telefono
                cboTelTipo.DataSource = tels.ListarTelefonosTipos();
                cboTelTipo.DisplayMember = "nombre_telefono";
                cboTelTipo.ValueMember = "tipo_telefono";

                cboPersonas.DataSource = perBL.ListarPersonasALL();
                cboPersonas.DisplayMember = "Nombre";
                cboPersonas.ValueMember = "Id Persona";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            int idPersona = int.Parse(cboPersonas.SelectedValue.ToString());

            TelefonoBE telbe = new TelefonoBE(
                           short.Parse(cboTelTipo.SelectedValue.ToString()),
                           idPersona,
                           txtCP.Text.Trim(),
                           txtTelC1.Text.Trim(),
                           txtTelC2.Text.Trim(),
                           txtTelC3.Text.Trim(),
                           txtTelCext.Text.Trim()
                           );
            TelefonosBL telBL = new TelefonosBL();
            

            if (telBL.TelefonoNew(telbe) == true) {
                MessageBox.Show(this, "Se guardo correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show(this, "Ocurrió un error", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
