using BE.DOCUMENTO;
using BE.PERSONA;
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
    public partial class frmModificarEntregaFinal : Form
    {

        private int idDocumento;
        public int IdDocumento { get => idDocumento; set => idDocumento = value; }

        public frmModificarEntregaFinal()
        {
            InitializeComponent();
        }

        ProyectoBL prBL = new ProyectoBL();
        EmpleadoBL emBL = new EmpleadoBL();
        EntregaFinalBE entregaFinalBE = new EntregaFinalBE();
        EntregaFinalBL entregaFinalBL = new EntregaFinalBL();

        private void frmModificarEntregaFinal_Load(object sender, EventArgs e) {
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

            entregaFinalBE = entregaFinalBL.ListarEntregaPorId(idDocumento);

            txtPath.Text = entregaFinalBE.Path_scan_reporte;
            cboProyecto.SelectedValue = entregaFinalBE.Id_proyecto;
            cboEmpleado.SelectedValue = entregaFinalBE.Id_encargado;
            dtpFecha.Value = entregaFinalBE.Fecha;

        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            try {
                entregaFinalBE.Path_scan_reporte = txtPath.Text.Trim();
                entregaFinalBE.Id_proyecto = Convert.ToInt32(cboProyecto.SelectedValue.ToString());
                entregaFinalBE.Id_encargado = Convert.ToInt32(cboEmpleado.SelectedValue.ToString());
                entregaFinalBE.Fecha = dtpFecha.Value;
                if (entregaFinalBL.ModificarEntregaFinal(entregaFinalBE) == true) {
                    MessageBox.Show(this, "Se modifico el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    throw new Exception("No se actualizo el registro");
                }
            } catch (Exception ex) {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }
    }
}
