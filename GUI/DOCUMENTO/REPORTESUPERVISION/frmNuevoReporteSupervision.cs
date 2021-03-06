﻿using BE.DOCUMENTO;
using BL.Documento;
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

namespace GUI.DOCUMENTO.REPORTESUPERVISION {
    public partial class frmNuevoReporteSupervision : Form {
        public frmNuevoReporteSupervision() {
            InitializeComponent();
        }

        ProyectoBL proBL = new ProyectoBL();
        EmpleadoBL empBL = new EmpleadoBL();
        ReporteSupervisionBL repBL = new ReporteSupervisionBL();
        ReporteSupervisionBE repBE = new ReporteSupervisionBE();

        private void frmNuevoReporteSupervision_Load(object sender, EventArgs e) {
            try {
                cboProyecto.DataSource = proBL.ListarProyectos();
                cboProyecto.DisplayMember = "Nombre";
                cboProyecto.ValueMember = "ID Proyecto";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de proyecto : " + ex.Message);
            }

            try {
                cboSupervisor.DataSource = empBL.ListarEmpleadosFull();
                cboSupervisor.DisplayMember = "Nombre Completo";
                cboSupervisor.ValueMember = "ID Empleado";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones empleado: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            repBE.Id_proyecto = Convert.ToInt32(cboProyecto.SelectedValue.ToString());
            repBE.Id_supervisor = Convert.ToInt32(cboSupervisor.SelectedValue.ToString());
            repBE.Fecha_reporte = dtpFechaReporte.Value;
            repBE.Path_scan_reporte = txtPathRep.Text.Trim();
            repBE.Detalles_reporte = txtDetalles.Text.Trim();

            if (repBL.ReporteSupervisionNew(repBE) == true) {
                MessageBox.Show(this, "Se guardo correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show(this, "Ocurrió un error", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
