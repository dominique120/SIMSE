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


namespace GUI.PERSONA.PersonaDeInteres
{
    public partial class frmNuevaPersonaDeInteres : Form
    {
        public frmNuevaPersonaDeInteres()
        {
            InitializeComponent();
        }

        PersonaDeInteresBL puest = new PersonaDeInteresBL();
        PersonaDeInteresBL proy = new PersonaDeInteresBL();

        private void frmNuevaPersonaDeInteres_Load(object sender, EventArgs e)
        {
            //informacion
            try
            { //Listar Puestos
                cboPuesto.DataSource = puest.ListarPuestos();
                cboPuesto.DisplayMember = "desc_puesto";
                cboPuesto.ValueMember = "id_puesto";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al poblar opciones de puesto : " + ex.Message);
            }

            //Listar Proyecto
            try
            {

                cboProyecto.DataSource = proy.ListarProyecto();
                cboProyecto.DisplayMember = "nom_proyecto";
                cboProyecto.ValueMember = "id_proyecto";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al poblar opciones de proyecto : " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)

        {
            try
            {
                //Codifique
                // 1. Nuevo ID de Persona
                NewIdBL newId = new NewIdBL();
                int idPersonaIn = newId.NewId();

                // 2. Nueva Puesto y proyecto
                PersonaDeInteresBE objPersonaDeInteres = new PersonaDeInteresBE();
                objPersonaDeInteres.Puesto = cboPuesto.SelectedValue.ToString();
                objPersonaDeInteres.Id_proyecto = cboProyecto.SelectedValue.ToString();
                objPersonaDeInteres.Nom_persona = txtNombrePersona.Text.Trim();


                //Insertamos el nuevo 


                if (puest.InsertarPersonaInt(objPersonaDeInteres) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se pudo insertar registro. Contacte con IT.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombrePersona.Text = "";
            txtNombrePersona.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
