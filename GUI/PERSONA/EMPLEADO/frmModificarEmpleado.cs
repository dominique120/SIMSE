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
    public partial class frmModificarEmpleado : Form {
        EmpleadoBL emBL = new EmpleadoBL();
        ClienteBL cliBL = new ClienteBL();
        PersonaFuenteBL personaFuenteBL = new PersonaFuenteBL();
        PersonaDeInteresBL puest = new PersonaDeInteresBL();
        EmpleadoBE empbe = new EmpleadoBE();
        public frmModificarEmpleado() {
            InitializeComponent();
        }

        private void frmModificarEmpleado_Load(object sender, EventArgs e) {
            try { 
                cboBuscarEmpleado.DataSource = personaFuenteBL.ListarEmpleados(); ;
                cboBuscarEmpleado.DisplayMember = "fullnom";
                cboBuscarEmpleado.ValueMember = "id_persona";

            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de puesto : " + ex.Message);
            }

            //informacion
            try { //Listar Puestos
                cboPuesto.DataSource = puest.ListarPuestos();
                cboPuesto.DisplayMember = "desc_puesto";
                cboPuesto.ValueMember = "id_puesto";

            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de puesto : " + ex.Message);
            }
        }

        private void txtBuscar_Click(object sender, EventArgs e) {
            int idPersona = int.Parse(cboBuscarEmpleado.SelectedValue.ToString());

            empbe = emBL.ListarEmpleadosPorId(idPersona);

            txtApellido.Text = empbe.Primer_ape;
            txtDocumento.Text = empbe.Doc_oficial;
            txtSApellido.Text = empbe.Segundo_ape;
            txtSNombre.Text = empbe.Segundo_nom;
            txtRuc.Text = empbe.Ruc_empleado;
            txtNombre.Text = empbe.Primer_nom;
            dtpFecIni.Value = empbe.Fecha_inicio;
            dtpFecNac.Value = empbe.Fecha_nacimiento;
            cboPuesto.SelectedValue = empbe.Puesto_empleado;
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e) {

            empbe.Primer_ape = txtApellido.Text;
            empbe.Doc_oficial=txtDocumento.Text;
            empbe.Segundo_ape=txtSApellido.Text;
            empbe.Segundo_nom=txtSNombre.Text;
            empbe.Ruc_empleado=txtRuc.Text;
            empbe.Primer_nom=txtNombre.Text;
            empbe.Fecha_inicio=dtpFecIni.Value;
            empbe.Fecha_nacimiento = dtpFecNac.Value;
            empbe.Puesto_empleado = short.Parse(cboPuesto.SelectedValue.ToString());

            if (emBL.ModificarEmpleado(empbe) == true) {
                MessageBox.Show(this, "Se modifico el empleado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show(this, "Ocurrió un error al modificar el empleado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
