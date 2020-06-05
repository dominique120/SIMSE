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

        private void nuevoToolStripMenuItem3_Click(object sender, EventArgs e) {
            PERSONA.PersonaDeInteres.frmNuevaPersonaDeInteres frmNuevaPersonaDeInteres = new PERSONA.PersonaDeInteres.frmNuevaPersonaDeInteres();
            frmNuevaPersonaDeInteres.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e) {
            PERSONA.CLIENTE.frmModificarCliente frmModificarCliente = new PERSONA.CLIENTE.frmModificarCliente();
            frmModificarCliente.Show();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e) {
            PERSONA.CLIENTE.frmEliminarCliente frmEliminarCliente = new PERSONA.CLIENTE.frmEliminarCliente();
            frmEliminarCliente.Show();
        }

        private void nuevoToolStripMenuItem5_Click(object sender, EventArgs e) {
            AUTH.frmNewUser frmNewUser = new AUTH.frmNewUser();
            frmNewUser.Show();
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e) {

        }
    }
}
