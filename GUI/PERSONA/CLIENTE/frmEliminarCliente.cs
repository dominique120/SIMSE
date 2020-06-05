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
    public partial class frmEliminarCliente : Form {
        ClienteBL cliBL = new ClienteBL();
        ClienteBE cliBE = new ClienteBE();
        public frmEliminarCliente() {
            InitializeComponent();
        }

        private void frmEliminarCliente_Load(object sender, EventArgs e) {
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

        private void btnEliminar_Click(object sender, EventArgs e) {
            int idCliente = int.Parse(cboCliente.SelectedValue.ToString());

            DialogResult result = MessageBox.Show(this, "Esta seguro que desea eliminar el usuario?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {

                if (cliBL.EliminarCliente(idCliente, cliBE.Marketing) == true) {
                    MessageBox.Show(this, "Se elimino al cliente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmEliminarCliente_Load(this, null);
                } else {
                    MessageBox.Show(this, "El cliente tiene documentos o proyectos asociados, no se puede eliminar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
