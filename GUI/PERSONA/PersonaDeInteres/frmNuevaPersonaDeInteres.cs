using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BL.Persona;
using BL.UTIL;
using BE.PERSONA;
using BL.PersonaUTIL;


namespace GUI.PERSONA.PersonaDeInteres {
    public partial class frmNuevaPersonaDeInteres : Form {
        public frmNuevaPersonaDeInteres() {
            InitializeComponent();
        }

        PersonaDeInteresBL puest = new PersonaDeInteresBL();
        PersonaDeInteresBL proy = new PersonaDeInteresBL();

        private void OnlyLetters(object sender, KeyPressEventArgs e) {
            if (e.KeyChar != 8) {
                if (char.IsDigit(e.KeyChar) == true) {
                    e.Handled = true;
                }
            }
        }

        private void frmNuevaPersonaDeInteres_Load(object sender, EventArgs e) {
            //informacion
            try { //Listar Puestos
                cboPuesto.DataSource = puest.ListarPuestos();
                cboPuesto.DisplayMember = "desc_puesto";
                cboPuesto.ValueMember = "id_puesto";

            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de puesto : " + ex.Message);
            }

            //Listar Proyecto
            try {

                cboProyecto.DataSource = proy.ListarProyecto();
                cboProyecto.DisplayMember = "nom_proyecto";
                cboProyecto.ValueMember = "id_proyecto";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de proyecto : " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            try {
                // 1. Nuevo ID de Persona
                NewIdBL newId = new NewIdBL();
                int idPersonaIn = newId.NewId();

                // 2. Nueva Puesto y proyecto
                PersonaDeInteresBE objPersonaDeInteres = new PersonaDeInteresBE();
                objPersonaDeInteres.Id_persona = idPersonaIn;
                objPersonaDeInteres.Puesto = int.Parse(cboPuesto.SelectedValue.ToString());
                objPersonaDeInteres.Id_proyecto = int.Parse(cboProyecto.SelectedValue.ToString());
                objPersonaDeInteres.Nom_persona = txtNombrePersona.Text.Trim();
                objPersonaDeInteres.Id_directorio = objPersonaDeInteres.Id_proyecto;

                if (puest.InsertarPersonaInt(objPersonaDeInteres) == true) {
                    MessageBox.Show(this, "Se inserto la nueva persona", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    throw new Exception("Ocurrió un error al insertar la nueva persona.");
                }
            } catch (Exception ex) {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();

        }
    }
}
