using BL.Persona;
using BL.Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.PROYECTO {
    public partial class frmListar : Form {
        ProyectoBL proBL = new ProyectoBL();
        public frmListar() {
            InitializeComponent();
        }

        private void frmListar_Load(object sender, EventArgs e) {
            dtgProyectos.DataSource = proBL.ListarProyectos();
        }
    }
}
