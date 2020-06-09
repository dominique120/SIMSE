using BL.UTIL;
using GUI.PERSONA.UTIL.Telefonos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.PERSONA.UTIL.Telefonos {
    public partial class frmTelefonos : Form {
        public frmTelefonos() {
            InitializeComponent();
        }
        TelefonosBL tel = new TelefonosBL();

        private void frmTelefonos_Load(object sender, EventArgs e)
        {
            DataTable src = tel.ListarTelefonosFull();
            dtgTelefonos.DataSource = src;
            cboPersonas.DataSource = src;
            cboPersonas.DisplayMember = "Nombre";
            cboPersonas.ValueMember = "Id Persona";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int idPersona = int.Parse(cboPersonas.SelectedValue.ToString());
            dtgTelefonos.DataSource = tel.ListarTelefonosFullPorId(idPersona);
        }
    }
}
