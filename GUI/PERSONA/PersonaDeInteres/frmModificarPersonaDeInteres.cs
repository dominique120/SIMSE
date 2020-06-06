using BE;
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

namespace GUI.PERSONA.PersonaDeInteres {
    public partial class frmModificarPersonaDeInteres : Form {
        PersonaDeInteresBL perinteBL = new PersonaDeInteresBL();
        PersonaDeInteresBE perinteBE = new PersonaDeInteresBE();
        public frmModificarPersonaDeInteres() {
            InitializeComponent();
        }

        private void frmModificarPersonaDeInteres_Load(object sender, EventArgs e) {
            //informacion
            try { //Listar Puestos
                cboPuesto.DataSource = perinteBL.ListarPuestos();
                cboPuesto.DisplayMember = "desc_puesto";
                cboPuesto.ValueMember = "id_puesto";

            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de puesto : " + ex.Message);
            }

            //Listar Proyecto
            try {
                cboProyecto.DataSource = perinteBL.ListarProyecto();
                cboProyecto.DisplayMember = "nom_proyecto";
                cboProyecto.ValueMember = "id_proyecto";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de proyecto : " + ex.Message);
            }

            //Listar Personas
            try {
                cboPerInte.DataSource = perinteBL.ListarPersonasDeInteres();
                cboPerInte.DisplayMember = "nom_persona";
                cboPerInte.ValueMember = "id_persona";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de personas de interés : " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            int idPersona = int.Parse(cboPerInte.SelectedValue.ToString());
            try {
                perinteBE = perinteBL.ListarPersonasDeInteresPorId(idPersona);

                txtNombrePersona.Text = perinteBE.Nom_persona;
                cboProyecto.SelectedValue = perinteBE.Id_proyecto;
                cboPuesto.SelectedValue = perinteBE.Puesto;

            } catch (Exception ex) {
                throw new Exception("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            perinteBE.Puesto = int.Parse(cboPuesto.SelectedValue.ToString());
            perinteBE.Id_proyecto = int.Parse(cboProyecto.SelectedValue.ToString());
            perinteBE.Nom_persona = txtNombrePersona.Text;

            if (perinteBL.ModificarPersonaInteres(perinteBE) == true){
                MessageBox.Show(this, "Se actualizo la persona de interés", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show(this, "Ocurrió un error.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
