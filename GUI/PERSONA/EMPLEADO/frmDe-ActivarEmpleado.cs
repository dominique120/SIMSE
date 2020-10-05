using BE.PERSONA;
using BL.MarketingUTIL;
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

namespace GUI.PERSONA.EMPLEADO {
    public partial class frmDe_ActivarEmpleado : Form {
        EmpleadoBL empBL = new EmpleadoBL();
        EmpleadoBE empBE;
        public frmDe_ActivarEmpleado() {
            InitializeComponent();
        }

        private void frmDe_ActivarEmpleado_Load(object sender, EventArgs e) {
            try {

                EmpleadoBL bL = new EmpleadoBL();
                cboBuscarEmpleado.DataSource = bL.ListarEmpleadosFull(); ;
                cboBuscarEmpleado.DisplayMember = "Nombre Completo";
                cboBuscarEmpleado.ValueMember = "ID Empleado";

            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de puesto : " + ex.Message);
            }
        }

        private void txtBuscar_Click(object sender, EventArgs e) {
            if (empBL.RevisarEstado(int.Parse(cboBuscarEmpleado.SelectedValue.ToString())) == true) {
                btnEstado.Text = "DESACTIVAR";
                empBE = new EmpleadoBE(int.Parse(cboBuscarEmpleado.SelectedValue.ToString()), true);
            } else if (empBL.RevisarEstado(int.Parse(cboBuscarEmpleado.SelectedValue.ToString())) == false) {
                btnEstado.Text = "ACTIVAR";
                empBE = new EmpleadoBE(int.Parse(cboBuscarEmpleado.SelectedValue.ToString()), false);
            }
        }

        private void btnEstado_Click(object sender, EventArgs e) {
            empBL.UpdateEstado(empBE.Id_persona, !empBE.Estado);
            txtBuscar_Click(this, null);
            MessageBox.Show(this, "Se cambio el estado del empleado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
