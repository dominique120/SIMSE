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

namespace GUI.DOCUMENTO.REPORTETECNICO {
    public partial class frmListarReporteTecnico : Form {
        public frmListarReporteTecnico() {
            InitializeComponent();
        }

        ProyectoBL proBL = new ProyectoBL();
        ReporteSupervisionBL rep = new ReporteSupervisionBL();

        public void cargar() {
            DataTable reportes = rep.ListarReporteSupervisionProyecto(Convert.ToInt32(cboProyecto.SelectedValue.ToString()));
            dtgLRS.DataSource = reportes;
        }

        private void frmListarReporteTecnico_Load(object sender, EventArgs e) {
            try {
                cboProyecto.DataSource = proBL.ListarProyectos();
                cboProyecto.DisplayMember = "Nombre";
                cboProyecto.ValueMember = "ID Proyecto";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de proyecto: " + ex.Message);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e) {
            cargar();
        }

        private void btnNuevo_Click(object sender, EventArgs e) {
            frmNuevoReporteTecnico frmRep = new frmNuevoReporteTecnico();
            frmRep.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            DialogResult lt = MessageBox.Show(this, "Desea eliminar este reporte?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (lt == DialogResult.Yes) {
                if (rep.EliminarReporteSupervision(int.Parse(dtgLRS.CurrentRow.Cells[0].Value.ToString())) == true) {
                    MessageBox.Show(this, "Se elimino correctamente el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar();
                }
            } else {
                MessageBox.Show(this, "Ocurrió un error al eliminar el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            try {
                frmModificarReporteTecnico modEntr = new frmModificarReporteTecnico();
                modEntr.IdDocumento = int.Parse(dtgLRS.CurrentRow.Cells[0].Value.ToString());
                modEntr.ShowDialog();
                cargar();
            } catch (Exception z) {
                throw new Exception(z.Message);
            }
        }
    }
}
