using BE.DOCUMENTO;
using BL.Documento;
using BL.Persona;
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
    public partial class frmModificarPlano : Form {
        public frmModificarPlano() {
            InitializeComponent();
        }

        private int idDocumento;
        public int IdDocumento { get => idDocumento; set => idDocumento = value; }

        ProyectoBL proBL = new ProyectoBL();
        PlanosBL plaBL = new PlanosBL();
        EmpleadoBL empBL = new EmpleadoBL();
        PlanoBE plBE = new PlanoBE();

        private void frmModificarPlano_Load(object sender, EventArgs e) {
            try {
                cboProyecto.DataSource = proBL.ListarProyectos();
                cboProyecto.DisplayMember = "Nombre";
                cboProyecto.ValueMember = "ID Proyecto";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de proyecto : " + ex.Message);
            }

            try {
                cboTipo.DataSource = plaBL.ListarTiposDePlano();
                cboTipo.DisplayMember = "nom_tipo_plano";
                cboTipo.ValueMember = "id_tipo_plano";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de tipo de plano : " + ex.Message);
            }

            try {
                cboAprobado.DataSource = empBL.ListarEmpleadosFull();
                cboAprobado.DisplayMember = "Nombre Completo";
                cboAprobado.ValueMember = "ID Empleado";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones empleado: " + ex.Message);
            }

            try {
                cboDibujopor.DataSource = empBL.ListarEmpleadosFull();
                cboDibujopor.DisplayMember = "Nombre Completo";
                cboDibujopor.ValueMember = "ID Empleado";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones empleado: " + ex.Message);
            }

            plBE = plaBL.ListarPlanoPorId(idDocumento);

            cboProyecto.SelectedValue = plBE.Id_proyecto;
            txtNombre.Text = plBE.Nom_plano;
            cboDibujopor.SelectedValue = plBE.Dibujado_por;
            cboDibujopor.SelectedValue = plBE.Revisado_por;
            cboTipo.SelectedValue = plBE.Tipo_plano;
            txtPath.Text = plBE.Path_plano;
            txtRevision.Text = plBE.Revision;
            dtpFecCrea.Value = plBE.Fecha_creacion;
            dtpFechaEnvio.Value = plBE.Fecha_envio;
            dtpFechRevi.Value = plBE.Fecha_revision;
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            plBE.Id_proyecto = Convert.ToInt32(cboProyecto.SelectedValue.ToString());
            plBE.Nom_plano = txtNombre.Text.Trim();
            plBE.Dibujado_por = Convert.ToInt32(cboDibujopor.SelectedValue.ToString());
            plBE.Revisado_por = Convert.ToInt32(cboDibujopor.SelectedValue.ToString());
            plBE.Tipo_plano = Convert.ToInt32(cboTipo.SelectedValue.ToString());
            plBE.Path_plano = txtPath.Text.Trim();
            plBE.Revision = txtRevision.Text.Trim();
            plBE.Fecha_creacion = dtpFecCrea.Value;
            plBE.Fecha_envio = dtpFechaEnvio.Value;
            plBE.Fecha_revision = dtpFechRevi.Value;

            if (plaBL.ModificarPlano(plBE) == true) {
                MessageBox.Show(this, "Se guardo correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show(this, "Ocurrió un error", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
