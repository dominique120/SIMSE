using BE.PROYECTO;
using BL.Persona;
using BL.Proyecto;
using BL.UTIL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.PROYECTO
{
    public partial class frmNuevoProyecto : Form
    {
        public frmNuevoProyecto()
        {
            InitializeComponent();
        }

        ClienteBL cliBE = new ClienteBL();
        ProyectoBL proyBL = new ProyectoBL();
        ProyectoBE proyBE = new ProyectoBE();

        private void frmNuevoProyecto_Load(object sender, EventArgs e) {
            //informacion direccion
            try {
                //Pais
                cboCliente.DataSource = cliBE.ListarClientes();
                cboCliente.DisplayMember = "nom_cliente";
                cboCliente.ValueMember = "id_persona";

                //Tipos
                cboDivision.DataSource = proyBL.ListarDivisiones();
                cboDivision.DisplayMember = "nombre_division";
                cboDivision.ValueMember = "id_division";

            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de proyecto : " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            proyBE.Dir_proyecto = txtDir.Text.Trim();
            proyBE.Fecha_inicio = dtpFecIni.Value;
            proyBE.Id_cliente = int.Parse(cboCliente.SelectedValue.ToString());
            proyBE.Id_division = int.Parse(cboDivision.SelectedValue.ToString());
            proyBE.Nom_proyecto = txtNombre.Text.Trim();

            if(proyBL.NuevoProyecto(proyBE) == true) {
                MessageBox.Show(this, "Se agrego el nuevo proyecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show(this, "No se agrego el nuevo proyecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
