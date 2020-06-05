using BE.PERSONA;
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

namespace GUI.PERSONA.CLIENTE {
    public partial class frmModificarCliente : Form {

        ClienteBL cliBL = new ClienteBL();
        ClienteBE cliBE = new ClienteBE();

        public frmModificarCliente() {
            InitializeComponent();
        }

        private void frmModificarCliente_Load(object sender, EventArgs e) {
            try {
                cboCliente.DataSource = cliBL.ListarClientes();
                cboCliente.DisplayMember = "nom_cliente";
                cboCliente.ValueMember = "id_persona";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de dirección : " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            int idCliente = int.Parse(cboCliente.SelectedValue.ToString());
            try {
                cliBE = cliBL.ListarClientesPorId(idCliente);

                txtDocumento.Text = cliBE.Doc_oficial;
                txtNombre.Text = cliBE.Nom_cliente;
            } catch (Exception ex) {
                throw new Exception("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            try {
                cliBE.Nom_cliente = txtNombre.Text.Trim();
                cliBE.Doc_oficial = txtDocumento.Text.Trim();

                if (cliBL.ModificarCliente(cliBE) == true) {
                    MessageBox.Show(this, "Se modifico el registro", "Alerta", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    frmModificarCliente_Load(this, null);
                } else {
                    throw new Exception("No se actualizo el registro");
                }
            } catch (Exception ex) {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }
    }
}
