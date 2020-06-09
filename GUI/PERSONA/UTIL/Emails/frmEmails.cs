using BL.UTIL;
using GUI.PERSONA.UTIL.Emails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.PERSONA.UTIL.Emails {
    public partial class frmEmails : Form {
        public frmEmails() {
            InitializeComponent();
        }
        EmailsBL email = new EmailsBL();

        private void frmEmails_Load(object sender, EventArgs e)
        {
            DataTable src = email.ListarEmailsFull();
            dtgEmail.DataSource = src;
            cboPersonas.DataSource = src;
            cboPersonas.DisplayMember = "Nombre";
            cboPersonas.ValueMember = "Id Persona";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int idPersona = int.Parse(cboPersonas.SelectedValue.ToString());
            dtgEmail.DataSource = email.ListarEmailsFullPorId(idPersona);
        }
    }
}
