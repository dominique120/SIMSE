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

namespace GUI.PERSONA.PersonaDeInteres {
    public partial class frmListar : Form {

        PersonaDeInteresBL perinteresBL = new PersonaDeInteresBL();

        public frmListar() {
            InitializeComponent();
        }

        private void frmListar_Load(object sender, EventArgs e) {
            dtgPerInteres.DataSource = perinteresBL.ListarPersonasDeInteresFull();
        }
    }
}
