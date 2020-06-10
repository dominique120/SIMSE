using BE.PERSONA;
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
    public partial class frmModificarTelefono : Form {
        public frmModificarTelefono() {
            InitializeComponent();
        }
        private int id_telefono;
        public int Id_telefono { get => id_telefono; set => id_telefono = value; }

        TelefonosBL telBL = new TelefonosBL();
        TelefonoBE telBE = new TelefonoBE();

        private void frmModificarTelefono_Load(object sender, EventArgs e) {
            try {
                //tipo telefono
                cboTelTipo.DataSource = telBL.ListarTelefonosTipos();
                cboTelTipo.DisplayMember = "nombre_telefono";
                cboTelTipo.ValueMember = "tipo_telefono";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de teléfono : " + ex.Message);
            }

            telBE = telBL.SelectTelefono(Id_telefono);

            txtCP.Text = telBE.Codigo_pais;
            txtTelC1.Text = telBE.Campo_1;
            txtTelC2.Text = telBE.Campo_2;
            txtTelC3.Text = telBE.Campo_3;
            txtTelCext.Text = telBE.Ext;
            cboTelTipo.SelectedValue = telBE.Tipo_telefono;
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                telBE.Codigo_pais = txtCP.Text;
                telBE.Campo_1 = txtTelC1.Text;
                telBE.Campo_2 = txtTelC2.Text;
                telBE.Campo_3 = txtTelC3.Text;
                telBE.Ext = txtTelCext.Text;
                telBE.Tipo_telefono = short.Parse(cboTelTipo.SelectedValue.ToString());

                if (telBL.ModificarTelefono(telBE) == true) {
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
