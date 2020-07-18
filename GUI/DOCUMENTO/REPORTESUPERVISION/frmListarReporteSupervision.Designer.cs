namespace GUI.DOCUMENTO.REPORTESUPERVISION
{
  partial class frmListarReporteSupervision
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.dtgLRS = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cboProyecto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.id_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_reporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalles_reporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path_scan_reporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLRS)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgLRS
            // 
            this.dtgLRS.AllowUserToAddRows = false;
            this.dtgLRS.AllowUserToDeleteRows = false;
            this.dtgLRS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgLRS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgLRS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLRS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_documento,
            this.nom_proyecto,
            this.supervisor,
            this.fecha_reporte,
            this.detalles_reporte,
            this.path_scan_reporte});
            this.dtgLRS.Location = new System.Drawing.Point(12, 41);
            this.dtgLRS.Name = "dtgLRS";
            this.dtgLRS.ReadOnly = true;
            this.dtgLRS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLRS.Size = new System.Drawing.Size(960, 508);
            this.dtgLRS.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(685, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(788, 12);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(897, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cboProyecto
            // 
            this.cboProyecto.FormattingEnabled = true;
            this.cboProyecto.Location = new System.Drawing.Point(127, 12);
            this.cboProyecto.Name = "cboProyecto";
            this.cboProyecto.Size = new System.Drawing.Size(244, 21);
            this.cboProyecto.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtrar Por Proyecto:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(388, 10);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // id_documento
            // 
            this.id_documento.DataPropertyName = "id_documento";
            this.id_documento.HeaderText = "Id Documento";
            this.id_documento.Name = "id_documento";
            this.id_documento.ReadOnly = true;
            // 
            // nom_proyecto
            // 
            this.nom_proyecto.DataPropertyName = "nom_proyecto";
            this.nom_proyecto.HeaderText = "Nombre del Proyecto";
            this.nom_proyecto.Name = "nom_proyecto";
            this.nom_proyecto.ReadOnly = true;
            // 
            // supervisor
            // 
            this.supervisor.DataPropertyName = "supervisor";
            this.supervisor.HeaderText = "Supervisor";
            this.supervisor.Name = "supervisor";
            this.supervisor.ReadOnly = true;
            // 
            // fecha_reporte
            // 
            this.fecha_reporte.DataPropertyName = "fecha_reporte";
            this.fecha_reporte.HeaderText = "Fecha del Reporte";
            this.fecha_reporte.Name = "fecha_reporte";
            this.fecha_reporte.ReadOnly = true;
            // 
            // detalles_reporte
            // 
            this.detalles_reporte.DataPropertyName = "detalles_reporte";
            this.detalles_reporte.HeaderText = "Detalles";
            this.detalles_reporte.Name = "detalles_reporte";
            this.detalles_reporte.ReadOnly = true;
            // 
            // path_scan_reporte
            // 
            this.path_scan_reporte.DataPropertyName = "path_scan_reporte";
            this.path_scan_reporte.HeaderText = "Ubicacion";
            this.path_scan_reporte.Name = "path_scan_reporte";
            this.path_scan_reporte.ReadOnly = true;
            // 
            // frmListarReporteSupervision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboProyecto);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtgLRS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(718, 396);
            this.Name = "frmListarReporteSupervision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Reportes de Supervision";
            this.Load += new System.EventHandler(this.frmListarReporteSupervision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLRS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dtgLRS;
    private System.Windows.Forms.Button btnNuevo;
    private System.Windows.Forms.Button btnModificar;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.ComboBox cboProyecto;
    private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_reporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalles_reporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn path_scan_reporte;
    }
}