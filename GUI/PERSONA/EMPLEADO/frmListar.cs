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

namespace GUI.PERSONA.EMPLEADO {
    public partial class frmListar : Form {
        EmpleadoBL empBL = new EmpleadoBL();
        public frmListar() {
            InitializeComponent();
        }

        private void frmListar_Load(object sender, EventArgs e) {
            dtgEmpleados.DataSource = empBL.ListarEmpleadosFull();
        }
    }
}
