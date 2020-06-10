using BL.UTIL;
using GUI.PERSONA.UTIL.Direcciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.PERSONA.UTIL {
    public partial class frmDirecciones : Form {
        public frmDirecciones() {
            InitializeComponent();
        }
        DireccionesBL dirs = new DireccionesBL();

        public void frmDirecciones_Load(object sender, EventArgs e) {
            DataTable direciones = dirs.ListarDireccionesFull();
            DataTable personas = dirs.ListarPersonasConDirecciones();
            dtgDirecciones.DataSource = direciones;
            cboPersonas.DataSource = personas;
            cboPersonas.DisplayMember = "Nombre";
            cboPersonas.ValueMember = "Id Persona";
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            int idPersona = int.Parse(cboPersonas.SelectedValue.ToString());
            dtgDirecciones.DataSource = dirs.ListarDireccionesFullPorId(idPersona);
        }

        private void btnNuevo_Click(object sender, EventArgs e) {
            frmNewDireccion newdir = new frmNewDireccion();
            newdir.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            try {
                frmModificarDireccion moddir = new frmModificarDireccion();
                moddir.Id_direccion = int.Parse(dtgDirecciones.CurrentRow.Cells[0].Value.ToString());
                moddir.ShowDialog();
            } catch (Exception z) {
                throw new Exception(z.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            DialogResult lt = MessageBox.Show(this, "Desea eliminar esta dirección?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        
            if (lt == DialogResult.Yes) {
                if (dirs.EliminarDireccion(int.Parse(dtgDirecciones.CurrentRow.Cells[0].Value.ToString())) == true) {
                    MessageBox.Show(this, "Se elimino correctamente la dirección", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else {
                MessageBox.Show(this, "Ocurrió un error al eliminar la dirección", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
