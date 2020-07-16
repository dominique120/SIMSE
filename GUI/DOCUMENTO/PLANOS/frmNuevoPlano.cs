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
    public partial class frmNuevoPlano : Form {
        public frmNuevoPlano() {
            InitializeComponent();
        }

        ProyectoBL proBL = new ProyectoBL();
        PlanosBL plaBL = new PlanosBL();
        EmpleadoBL empBE = new EmpleadoBL();
        PlanoBE plBE = new PlanoBE();

        private void frmNuevoPlano_Load(object sender, EventArgs e) {
            try {
                cboProyecto.DataSource = proBL.ListarProyectos();
                cboProyecto.DisplayMember = "Nombre";
                cboProyecto.ValueMember = "ID Proyecto";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de proyecto : " + ex.Message);
            }

            try {
                cboAprobado.DataSource = empBE.ListarEmpleadosFull();
                cboAprobado.DisplayMember = "Nombre Completo";
                cboAprobado.ValueMember = "ID Empleado";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones empleado: " + ex.Message);
            }

            try {
                cboTipo.DataSource = plaBL.ListarTiposDePlano();
                cboTipo.DisplayMember = "nom_tipo_plano";
                cboTipo.ValueMember = "id_tipo_plano";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de tipo de plano : " + ex.Message);
            }

            try {
                cboDibujopor.DataSource = empBE.ListarEmpleadosFull();
                cboDibujopor.DisplayMember = "Nombre Completo";
                cboDibujopor.ValueMember = "ID Empleado";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones empleado: " + ex.Message);
            }


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

            if (plaBL.PlanoNew(plBE) == true) {
                MessageBox.Show(this, "Se guardo correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show(this, "Ocurrió un error", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

