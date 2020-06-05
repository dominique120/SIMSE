using BL.UTIL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.PROYECTO
{
    public partial class frmNuevoProyecto : Form
    {
        public frmNuevoProyecto()
        {
            InitializeComponent();
        }

        DireccionesBL dirs = new DireccionesBL();

        private void frmNuevoProyecto_Load(object sender, EventArgs e) {
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
    }
}
