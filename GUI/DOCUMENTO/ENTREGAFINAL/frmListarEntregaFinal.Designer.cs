namespace GUI.DOCUMENTO.ENTREGAFINAL
{
  partial class frmListarEntregaFinal
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
            this.dtgEntregasFinales = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.id_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path_scan_reporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEntregasFinales)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEntregasFinales
            // 
            this.dtgEntregasFinales.AllowUserToAddRows = false;
            this.dtgEntregasFinales.AllowUserToDeleteRows = false;
            this.dtgEntregasFinales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgEntregasFinales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEntregasFinales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEntregasFinales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_documento,
            this.nom_proyecto,
            this.encargado,
            this.path_scan_reporte,
            this.fecha});
            this.dtgEntregasFinales.Location = new System.Drawing.Point(12, 58);
            this.dtgEntregasFinales.Name = "dtgEntregasFinales";
            this.dtgEntregasFinales.ReadOnly = true;
            this.dtgEntregasFinales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEntregasFinales.Size = new System.Drawing.Size(960, 491);
            this.dtgEntregasFinales.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(897, 16);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(801, 16);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(705, 16);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtrar Por Fechas:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(177, 16);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(102, 20);
            this.dtpInicio.TabIndex = 7;
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(335, 16);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(102, 20);
            this.dtpFin.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fin:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(453, 16);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 8;
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
            // encargado
            // 
            this.encargado.DataPropertyName = "encargado";
            this.encargado.HeaderText = "Encargado";
            this.encargado.Name = "encargado";
            this.encargado.ReadOnly = true;
            // 
            // path_scan_reporte
            // 
            this.path_scan_reporte.DataPropertyName = "path_scan_reporte";
            this.path_scan_reporte.HeaderText = "Ubicacion";
            this.path_scan_reporte.Name = "path_scan_reporte";
            this.path_scan_reporte.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // frmListarEntregaFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dtgEntregasFinales);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(752, 403);
            this.Name = "frmListarEntregaFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Entrega Final";
            this.Load += new System.EventHandler(this.frmListarEntregaFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEntregasFinales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dtgEntregasFinales;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Button btnModificar;
    private System.Windows.Forms.Button btnNuevo;
    private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn path_scan_reporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
    }
}