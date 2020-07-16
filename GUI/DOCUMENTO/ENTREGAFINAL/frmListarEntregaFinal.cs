using BL.Documento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DOCUMENTO.ENTREGAFINAL {
    public partial class frmListarEntregaFinal : Form {
        public frmListarEntregaFinal() {
            InitializeComponent();
        }

        EntregaFinalBL eBL = new EntregaFinalBL();

        public void cargar() {
            DataTable entregasFinales = eBL.ListarEntregasFinalesFechas(dtpInicio.Value, dtpFin.Value);
            dtgEntregasFinales.DataSource = entregasFinales;
        }

        private void frmListarEntregaFinal_Load(object sender, EventArgs e) {
            //cargar();
        }

        private void btnFiltrar_Click(object sender, EventArgs e) {
            cargar();
        }

        private void btnNuevo_Click(object sender, EventArgs e) {
            frmNuevoEntregaFinal frmnentr = new frmNuevoEntregaFinal();
            frmnentr.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            try {
                frmModificarEntregaFinal modEntr = new frmModificarEntregaFinal();
                modEntr.IdDocumento = int.Parse(dtgEntregasFinales.CurrentRow.Cells[0].Value.ToString());
                modEntr.ShowDialog();
                cargar();
            } catch (Exception z) {
                throw new Exception(z.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            DialogResult lt = MessageBox.Show(this, "Desea eliminar esta entrega?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (lt == DialogResult.Yes) {
                if (eBL.EliminarEntregaFinal(int.Parse(dtgEntregasFinales.CurrentRow.Cells[0].Value.ToString())) == true) {
                    MessageBox.Show(this, "Se elimino correctamente el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar();
                }
            } else {
                MessageBox.Show(this, "Ocurrió un error al eliminar el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
