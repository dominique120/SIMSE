using BE.PERSONA;
using BL.Persona;
using BL.PersonaUTIL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.PERSONA.EMPLEADO
{
    public partial class frmNuevoEmpleado : Form
    {
        NewIdBL idPerson = new NewIdBL();
        PersonaDeInteresBL puest = new PersonaDeInteresBL();
        EmpleadoBL emBL = new EmpleadoBL();
        public frmNuevoEmpleado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if (
            String.IsNullOrWhiteSpace(txtApellido.Text) ||
            String.IsNullOrWhiteSpace(txtDocumento.Text) ||
            String.IsNullOrWhiteSpace(txtSApellido.Text) ||
            String.IsNullOrWhiteSpace(txtRuc.Text) 
            ) {
                MessageBox.Show(this, "Falto ingresar un campo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idEmpleado = NewPersonId();
            EmpleadoBE emBE = new EmpleadoBE(idPerson.NewId(), short.Parse(cboPuesto.SelectedValue.ToString()),
                                                txtDocumento.Text.Trim(), txtRuc.Text.Trim(),
                                                dtpFecNac.Value, dtpFecIni.Value,
                                                txtNombre.Text.Trim(), txtSNombre.Text.Trim(),
                                                txtApellido.Text.Trim(), txtSApellido.Text.Trim(), false);

            try {
                if (emBL.NuevoEmpleado(emBE) == true) {
                    MessageBox.Show(this, "Se ingreso un nuevo empleado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show(this, "Ocurrió un error insertando al empleado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private int NewPersonId() {
            NewIdBL newid = new NewIdBL();
            int idPersona = newid.NewId();
            return idPersona;
        }

        private void OnlyLetters(object sender, KeyPressEventArgs e) {
            if (e.KeyChar != 8) {
                if (char.IsDigit(e.KeyChar) == true) {
                    e.Handled = true;
                }
            }
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e) {
            if (e.KeyChar != 8) {
                if (char.IsDigit(e.KeyChar) == false) {
                    e.Handled = true;
                }
            }
        }

        private void frmNuevoEmpleado_Load(object sender, EventArgs e) {
            //informacion
            try { //Listar Puestos
                cboPuesto.DataSource = puest.ListarPuestos();
                cboPuesto.DisplayMember = "desc_puesto";
                cboPuesto.ValueMember = "id_puesto";

            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de puesto : " + ex.Message);
            }
        }
    }
}
