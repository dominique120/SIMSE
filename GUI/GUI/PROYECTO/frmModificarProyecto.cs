using BE.PERSONA;
using BE.PROYECTO;
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
    public partial class frmModificarProyecto : Form {
        PersonaDeInteresBL perinteBL = new PersonaDeInteresBL();
        ProyectoBL proyBL = new ProyectoBL();
        ClienteBL cliBL = new ClienteBL();
        ProyectoBE proyBE = new ProyectoBE();
        public frmModificarProyecto() {
            InitializeComponent();
        }

        private void frmModificarProyecto_Load(object sender, EventArgs e) {
            try {
                cboBuscar.DataSource = perinteBL.ListarProyecto();
                cboBuscar.DisplayMember = "nom_proyecto";
                cboBuscar.ValueMember = "id_proyecto";

                cboCliente.DataSource = cliBL.ListarClientes();
                cboCliente.DisplayMember = "nom_cliente";
                cboCliente.ValueMember = "id_persona";

                cboDivision.DataSource = proyBL.ListarDivisiones();
                cboDivision.DisplayMember = "nombre_division";
                cboDivision.ValueMember = "id_division";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de proyecto : " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            int idProyecto = int.Parse(cboBuscar.SelectedValue.ToString());

            try {
                proyBE = proyBL.ListarPersonasDeInteresPorId(idProyecto);

                txtDir.Text = proyBE.Dir_proyecto;
                txtNombre.Text = proyBE.Nom_proyecto;
                dtpFecIni.Value = proyBE.Fecha_inicio;
                dtpFin.Value = proyBE.Fecha_fin;
                cboCliente.SelectedValue = proyBE.Id_cliente;
                cboDivision.SelectedValue = proyBE.Id_division;

            } catch (Exception ex) {
                throw new Exception("Ocurrió un error: " + ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e) {
            proyBE.Dir_proyecto = txtDir.Text;
            proyBE.Nom_proyecto = txtNombre.Text;
            proyBE.Fecha_inicio = dtpFecIni.Value;
            proyBE.Fecha_fin = dtpFin.Value;
            proyBE.Id_cliente = int.Parse(cboCliente.SelectedValue.ToString());
            proyBE.Id_division = int.Parse(cboDivision.SelectedValue.ToString());

            if (proyBL.ModificarProyecto(proyBE) == true) {
                MessageBox.Show(this, "Se actualizo el proyecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show(this, "Ocurrió un error.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
