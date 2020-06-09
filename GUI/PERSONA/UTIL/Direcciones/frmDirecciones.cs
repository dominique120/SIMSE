using BL.UTIL;
using GUI.PERSONA.UTIL.Direcciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.PERSONA.UTIL {
    public partial class frmDirecciones : Form {
        public frmDirecciones() {
            InitializeComponent();
        }
        DireccionesBL dirs = new DireccionesBL();

        public void frmDirecciones_Load(object sender, EventArgs e) {
            DataTable src = dirs.ListarDireccionesFull();
            dtgDirecciones.DataSource = src;
            cboPersonas.DataSource = src;
            cboPersonas.DisplayMember = "Nombre";
            cboPersonas.ValueMember = "Id Persona";
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            int idPersona = int.Parse(cboPersonas.SelectedValue.ToString());
            dtgDirecciones.DataSource = dirs.ListarDireccionesFullPorId(idPersona);
        }

        private void btnNuevo_Click(object sender, EventArgs e) {
            frmNewDireccion newdir = new frmNewDireccion();
            newdir.Show();
        }
    }
}
