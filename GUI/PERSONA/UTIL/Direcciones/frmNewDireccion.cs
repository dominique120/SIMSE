using BL.UTIL;
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
using BE.PERSONA;

namespace GUI.PERSONA.UTIL.Direcciones {
    public partial class frmNewDireccion : Form {
        public frmNewDireccion() {
            InitializeComponent();
        }

        DireccionesBL dirs = new DireccionesBL();
        PersonaBL perBL = new PersonaBL();

        private void frmNewDireccion_Load(object sender, EventArgs e) {
            cboPersonas.DataSource = perBL.ListarPersonasALL();
            cboPersonas.DisplayMember = "Nombre";
            cboPersonas.ValueMember = "Id Persona";


                 //informacion direccion
            try {
                //Pais
                cboDirPais.DataSource = dirs.ListarPaises();
                cboDirPais.DisplayMember = "nom_pais";
                cboDirPais.ValueMember = "id_pais";

                //Tipos
                cboDirTipo.DataSource = dirs.ListarDireccionesTipos();
                cboDirTipo.DisplayMember = "nombre_direccion";
                cboDirTipo.ValueMember = "tipo_direccion";

            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de dirección : " + ex.Message);
            }
        }

        private void cboDirPais_SelectionChangeCommitted(object sender, EventArgs e) {
            cboDirProvincia.DataSource = null;
            cboDirCiudad.DataSource = null;
            cboDirDistrito.DataSource = null;
            //Region
            try {
                cboDirProvincia.DataSource = dirs.ListarRegionesPorIdPais((byte)cboDirPais.SelectedValue);
                cboDirProvincia.DisplayMember = "nom_region";
                cboDirProvincia.ValueMember = "id_region";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de dirección : " + ex.Message);
            }
        }

        private void cboDirProvincia_SelectionChangeCommitted(object sender, EventArgs e) {
            cboDirCiudad.DataSource = null;
            cboDirDistrito.DataSource = null;
            //Ciudad
            try {
                cboDirCiudad.DataSource = dirs.ListarCiudadesPorIdRegion((int)cboDirProvincia.SelectedValue);
                cboDirCiudad.DisplayMember = "nom_ciudad";
                cboDirCiudad.ValueMember = "id_ciudad";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de dirección : " + ex.Message);
            }
        }

        private void cboDirCiudad_SelectionChangeCommitted(object sender, EventArgs e) {
            cboDirDistrito.DataSource = null;
            //Distrito
            try {
                cboDirDistrito.DataSource = dirs.ListarDistritosPorIdCiudad((int)cboDirCiudad.SelectedValue);
                cboDirDistrito.DisplayMember = "nom_distrito";
                cboDirDistrito.ValueMember = "id_distrito";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de dirección : " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            int idCliente = int.Parse(cboPersonas.SelectedValue.ToString());

            DireccionBE dirbe = new DireccionBE(
                byte.Parse(cboDirTipo.SelectedValue.ToString()),
                idCliente,
                short.Parse(cboDirPais.SelectedValue.ToString()),
                int.Parse(cboDirProvincia.SelectedValue.ToString()),
                int.Parse(cboDirCiudad.SelectedValue.ToString()),
                int.Parse(cboDirDistrito.SelectedValue.ToString()),
                txtDirLinea1.Text.Trim(),
                txtDirLinea2.Text.Trim(),
                txtDirPostal.Text.Trim()
            );
            DireccionesBL dirbl = new DireccionesBL();

            if (dirbl.DireccionNew(dirbe) == true) {
                MessageBox.Show(this, "Se guardo correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show(this, "Ocurrió un error", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
