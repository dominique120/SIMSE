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
    public partial class frmEliminarPersonaDeInteres : Form {
        PersonaDeInteresBL perinteBL = new PersonaDeInteresBL();
        public frmEliminarPersonaDeInteres() {
            InitializeComponent();
        }

        private void frmEliminarPersonaDeInteres_Load(object sender, EventArgs e) {
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

            DialogResult confirm = MessageBox.Show(this, "Esta seguro que desea eliminar a esta persona?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        
            if (confirm == DialogResult.Yes) {
                if (perinteBL.EliminarPersonaDeInteres(idPersona) == true) {
                    MessageBox.Show(this, "Se elimino a la persona de interés", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show(this, "No se pudo eliminar a la persona de interés. Es posible que tenga documentos asociados.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
