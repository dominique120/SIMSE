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

namespace GUI.DOCUMENTO.ENTREGAFINAL
{
  public partial class frmNuevoEntregaFinal : Form
  {
    public frmNuevoEntregaFinal()
    {
      InitializeComponent();
    }

        ProyectoBL prBL = new ProyectoBL();
        EmpleadoBL emBL = new EmpleadoBL();
        EntregaFinalBE entregaFinalBE = new EntregaFinalBE();
        EntregaFinalBL entregaFinalBL = new EntregaFinalBL();

        private void btnGuardar_Click(object sender, EventArgs e) {
            entregaFinalBE.Path_scan_reporte = txtPath.Text.Trim();
            entregaFinalBE.Id_proyecto = Convert.ToInt32(cboProyecto.SelectedValue.ToString());
            entregaFinalBE.Id_encargado = Convert.ToInt32(cboEmpleado.SelectedValue.ToString());
            entregaFinalBE.Fecha = dtpFecha.Value;

            if (entregaFinalBL.EntregaFinalNew(entregaFinalBE) == true) {
                MessageBox.Show(this, "Se guardo correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show(this, "Ocurrió un error", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmNuevoEntregaFinal_Load(object sender, EventArgs e) {
            try { 
            cboProyecto.DataSource = prBL.ListarProyectos();
            cboProyecto.DisplayMember = "Nombre";
            cboProyecto.ValueMember = "ID Proyecto";

            cboEmpleado.DataSource = emBL.ListarEmpleadosFull(); ;
            cboEmpleado.DisplayMember = "Nombre Completo";
            cboEmpleado.ValueMember = "ID Empleado";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones: " + ex.Message);
            }
        }
    }
}
