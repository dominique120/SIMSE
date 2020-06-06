using BL.AUTH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.AUTH {
    public partial class frmListar : Form {
        AuthBL authBL = new AuthBL();
        public frmListar() {
            InitializeComponent();
        }

        private void frmListar_Load(object sender, EventArgs e) {
            dtgCredenciales.DataSource = authBL.ListarCredenciales();
        }
    }
}
