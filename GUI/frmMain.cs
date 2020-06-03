using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e) {
            PERSONA.CLIENTE.frmNuevoCliente frmcliente = new PERSONA.CLIENTE.frmNuevoCliente();
                frmcliente.Show();
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e) {
            PERSONA.EMPLEADO.frmNuevoEmpleado frmempleado = new PERSONA.EMPLEADO.frmNuevoEmpleado();
            frmempleado.Show();
        }

        private void nuevoToolStripMenuItem4_Click(object sender, EventArgs e) {
            PROYECTO.frmNuevoProyecto frmproyecto = new PROYECTO.frmNuevoProyecto();
            frmproyecto.Show();
        }
    }
}
