using BL.Documento;
using BL.Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DOCUMENTO.PLANOS {
    public partial class frmListarPlanos : Form {
        public frmListarPlanos() {
            InitializeComponent();
        }

        PlanosBL pBL = new PlanosBL();
        ProyectoBL proBL = new ProyectoBL();

        public void cargar() {
            DataTable planos = pBL.ListarPlanosPorProyecto(Convert.ToInt32(cboProyecto.SelectedValue.ToString()));
            dtgPlanos.DataSource = planos;
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            DialogResult lt = MessageBox.Show(this, "Desea eliminar este plano?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (lt == DialogResult.Yes) {
                if (pBL.EliminarPlano(int.Parse(dtgPlanos.CurrentRow.Cells[0].Value.ToString())) == true) {
                    MessageBox.Show(this, "Se elimino correctamente el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar();
                }
            } else {
                MessageBox.Show(this, "Ocurrió un error al eliminar el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e) {
            cargar();
        }

        private void frmListarPlanos_Load(object sender, EventArgs e) {
            try {
                cboProyecto.DataSource = proBL.ListarProyectos();
                cboProyecto.DisplayMember = "Nombre";
                cboProyecto.ValueMember = "ID Proyecto";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de proyecto : " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e) {
            frmNuevoPlano nuevoPlano = new frmNuevoPlano();
            nuevoPlano.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            try {
                frmModificarPlano modEntr = new frmModificarPlano();
                modEntr.IdDocumento = int.Parse(dtgPlanos.CurrentRow.Cells[0].Value.ToString());
                modEntr.ShowDialog();
                cargar();
            } catch (Exception z) {
                throw new Exception(z.Message);
            }
        }
    }
}
