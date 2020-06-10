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
    public partial class frmModificarEmail : Form {

        
        public frmModificarEmail() {
            InitializeComponent();
        }

        EmailsBL emBL = new EmailsBL();
        EmailBE emBE = new EmailBE();

        private int id_email;
        public int Id_email { get => id_email; set => id_email = value; }

        private void frmModificarEmail_Load(object sender, EventArgs e) {
            try {
                //tipo telefono
                cboEmailTipo.DataSource = emBL.ListarEmailsTipos();
                cboEmailTipo.DisplayMember = "nombre_email";
                cboEmailTipo.ValueMember = "tipo_email";

            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones : " + ex.Message);
            }


            emBE = emBL.SelectEmail(id_email);

            txtEmailEmail.Text = emBE.Direccion_email;
            cboEmailTipo.SelectedValue = emBE.Tipo_email;
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            try {

                emBE.Direccion_email = txtEmailEmail.Text.Trim();
                emBE.Tipo_email = short.Parse(cboEmailTipo.SelectedValue.ToString()) ;

                if (emBL.ModificarEmail(emBE) == true) {
                    MessageBox.Show(this, "Se modifico el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    throw new Exception("No se actualizo el registro");
                }
            } catch (Exception ex) {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }
    }
}
