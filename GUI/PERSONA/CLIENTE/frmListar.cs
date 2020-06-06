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

namespace GUI.PERSONA.CLIENTE {
    public partial class frmListar : Form {
        ClienteBL cliBL = new ClienteBL();
        public frmListar() {
            InitializeComponent();
        }

        private void frmListar_Load(object sender, EventArgs e) {
            dtgClientes.DataSource = cliBL.ListarClientesFull();
        }
    }
}
