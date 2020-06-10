using BE.PERSONA;
using BL.PersonaUTIL;
using BL.UTIL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.PERSONA.UTIL.Direcciones {
    public partial class frmModificarDireccion : Form {
        public frmModificarDireccion() {
            InitializeComponent();
        }

        DireccionesBL dirs = new DireccionesBL();
        DireccionBE dirBE = new DireccionBE();

        private int id_direccion;
        public int Id_direccion { get => id_direccion; set => id_direccion = value; }

        private void frmModificarDireccion_Load(object sender, EventArgs e) {
            try {
                //Pais
                cboDirPais.DataSource = dirs.ListarPaises();
                cboDirPais.DisplayMember = "nom_pais";
                cboDirPais.ValueMember = "id_pais";

                //Tipos
                cboDirTipo.DataSource = dirs.ListarDireccionesTipos();
                cboDirTipo.DisplayMember = "nombre_direccion";
                cboDirTipo.ValueMember = "tipo_direccion";

                cboDirProvincia.DataSource = dirs.ListarRegiones();
                cboDirProvincia.DisplayMember = "nom_region";
                cboDirProvincia.ValueMember = "id_region";

                cboDirCiudad.DataSource = dirs.ListarCiudades();
                cboDirCiudad.DisplayMember = "nom_ciudad";
                cboDirCiudad.ValueMember = "id_ciudad";

                cboDirDistrito.DataSource = dirs.ListarDistritos();
                cboDirDistrito.DisplayMember = "nom_distrito";
                cboDirDistrito.ValueMember = "id_distrito";

            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de dirección : " + ex.Message);
            }

            dirBE = dirs.SelectDireccion(Id_direccion);

            cboDirPais.SelectedValue = dirBE.Dir_pais;
            cboDirProvincia.SelectedValue = dirBE.Dir_provincia;
            cboDirCiudad.SelectedValue = dirBE.Dir_ciudad;
            cboDirDistrito.SelectedValue = dirBE.Dir_distrito;
            txtDirLinea1.Text = dirBE.Dir_linea_1;
            txtDirLinea2.Text = dirBE.Dir_linea_2;
            txtDirPostal.Text = dirBE.Dir_codigo_postal;

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
            try {
                dirBE.Dir_pais = short.Parse(cboDirPais.SelectedValue.ToString());
                dirBE.Dir_provincia = int.Parse(cboDirProvincia.SelectedValue.ToString());
                dirBE.Dir_ciudad = int.Parse(cboDirCiudad.SelectedValue.ToString());
                dirBE.Dir_distrito = int.Parse(cboDirDistrito.SelectedValue.ToString());

                dirBE.Tipo_direccion = byte.Parse(cboDirTipo.SelectedValue.ToString());

                dirBE.Dir_linea_1 = txtDirLinea1.Text.Trim();
                dirBE.Dir_linea_2 = txtDirLinea2.Text.Trim();
                dirBE.Dir_codigo_postal = txtDirPostal.Text.Trim();
                
                if (dirs.ModificarDireccion(dirBE) == true) {
                    MessageBox.Show(this, "Se modifico el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    throw new Exception("No se actualizo el registro");
                }
            } catch (Exception ex) {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }
    }
}
