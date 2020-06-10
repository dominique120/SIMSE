using BL.UTIL;
using GUI.PERSONA.UTIL.Telefonos;
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
    public partial class frmTelefonos : Form {
        public frmTelefonos() {
            InitializeComponent();
        }
        TelefonosBL tel = new TelefonosBL();

        private void frmTelefonos_Load(object sender, EventArgs e)
        {
            DataTable src = tel.ListarTelefonosFull();
            dtgTelefonos.DataSource = src;
            cboPersonas.DataSource = src;
            cboPersonas.DisplayMember = "Nombre";
            cboPersonas.ValueMember = "Id Persona";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int idPersona = int.Parse(cboPersonas.SelectedValue.ToString());
            dtgTelefonos.DataSource = tel.ListarTelefonosFullPorId(idPersona);
        }

        private void btnNuevo_Click(object sender, EventArgs e) {
            frmNuevoTelefono newtel = new frmNuevoTelefono();
            newtel.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            DialogResult lt = MessageBox.Show(this, "Desea eliminar esta dirección?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            TelefonosBL telsBE = new TelefonosBL();
            if (lt == DialogResult.Yes) {
                if (telsBE.EliminarTelefono(int.Parse(dtgTelefonos.CurrentRow.Cells[0].Value.ToString())) == true) {
                    MessageBox.Show(this, "Se elimino correctamente la dirección", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else {
                MessageBox.Show(this, "Ocurrió un error al eliminar la dirección", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            try {
                frmModificarTelefono modtel = new frmModificarTelefono();
                modtel.Id_telefono = int.Parse(dtgTelefonos.CurrentRow.Cells[0].Value.ToString());
                modtel.ShowDialog();
            } catch (Exception z) {
                throw new Exception(z.Message);
            }
        }
    }
}
