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
                //Distrito
                cboDirDistrito.DataSource = dirs.ListarDistritos();
                cboDirDistrito.DisplayMember = "nom_distrito";
                cboDirDistrito.ValueMember = "id_distrito";

                //Ciudad
                cboDirCiudad.DataSource = dirs.ListarCiudades();
                cboDirCiudad.DisplayMember = "nom_ciudad";
                cboDirCiudad.ValueMember = "id_ciudad";

                //Region
                cboDirProvincia.DataSource = dirs.ListarRegiones();
                cboDirProvincia.DisplayMember = "nom_region";
                cboDirProvincia.ValueMember = "id_region";

                //Pais
                cboDirPais.DataSource = dirs.ListarPaises();
                cboDirPais.DisplayMember = "nom_pais";
                cboDirPais.ValueMember = "id_pais";

                //Tipos
                cboDirTipo.DataSource = dirs.ListarDireccionesTipos();
                cboDirTipo.DisplayMember = "nombre_direccion";
                cboDirTipo.ValueMember = "tipo_direccion";

            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de direccion : " + ex.Message);
            }


        }
    }
}
