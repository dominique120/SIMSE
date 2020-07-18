namespace GUI.DOCUMENTO.PLANOS {
    partial class frmListarPlanos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dtgPlanos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cboProyecto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.id_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_tipo_plano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dibujadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revisadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_plano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_revision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_envio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path_plano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPlanos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPlanos
            // 
            this.dtgPlanos.AllowUserToAddRows = false;
            this.dtgPlanos.AllowUserToDeleteRows = false;
            this.dtgPlanos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPlanos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPlanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPlanos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_documento,
            this.revision,
            this.nom_tipo_plano,
            this.dibujadoPor,
            this.revisadoPor,
            this.nom_plano,
            this.fecha_creacion,
            this.fecha_revision,
            this.fecha_envio,
            this.path_plano});
            this.dtgPlanos.Location = new System.Drawing.Point(12, 53);
            this.dtgPlanos.Name = "dtgPlanos";
            this.dtgPlanos.ReadOnly = true;
            this.dtgPlanos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPlanos.Size = new System.Drawing.Size(960, 496);
            this.dtgPlanos.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(695, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(801, 12);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
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
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cboProyecto
            // 
            this.cboProyecto.FormattingEnabled = true;
            this.cboProyecto.Location = new System.Drawing.Point(117, 12);
            this.cboProyecto.Name = "cboProyecto";
            this.cboProyecto.Size = new System.Drawing.Size(267, 21);
            this.cboProyecto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar Por Proyecto:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(391, 11);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 4;
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
            // revision
            // 
            this.revision.DataPropertyName = "revision";
            this.revision.HeaderText = "Revision";
            this.revision.Name = "revision";
            this.revision.ReadOnly = true;
            // 
            // nom_tipo_plano
            // 
            this.nom_tipo_plano.DataPropertyName = "nom_tipo_plano";
            this.nom_tipo_plano.HeaderText = "Tipo de Plano";
            this.nom_tipo_plano.Name = "nom_tipo_plano";
            this.nom_tipo_plano.ReadOnly = true;
            // 
            // dibujadoPor
            // 
            this.dibujadoPor.DataPropertyName = "dibujadoPor";
            this.dibujadoPor.HeaderText = "Dibujado Por";
            this.dibujadoPor.Name = "dibujadoPor";
            this.dibujadoPor.ReadOnly = true;
            // 
            // revisadoPor
            // 
            this.revisadoPor.DataPropertyName = "revisadoPor";
            this.revisadoPor.HeaderText = "Revisado Por";
            this.revisadoPor.Name = "revisadoPor";
            this.revisadoPor.ReadOnly = true;
            // 
            // nom_plano
            // 
            this.nom_plano.DataPropertyName = "nom_plano";
            this.nom_plano.HeaderText = "Nombre del Plano";
            this.nom_plano.Name = "nom_plano";
            this.nom_plano.ReadOnly = true;
            // 
            // fecha_creacion
            // 
            this.fecha_creacion.DataPropertyName = "fecha_creacion";
            this.fecha_creacion.HeaderText = "Fecha Creacion";
            this.fecha_creacion.Name = "fecha_creacion";
            this.fecha_creacion.ReadOnly = true;
            // 
            // fecha_revision
            // 
            this.fecha_revision.DataPropertyName = "fecha_revision";
            this.fecha_revision.HeaderText = "Fecha Revision";
            this.fecha_revision.Name = "fecha_revision";
            this.fecha_revision.ReadOnly = true;
            // 
            // fecha_envio
            // 
            this.fecha_envio.DataPropertyName = "fecha_envio";
            this.fecha_envio.HeaderText = "Fecha de Envio";
            this.fecha_envio.Name = "fecha_envio";
            this.fecha_envio.ReadOnly = true;
            // 
            // path_plano
            // 
            this.path_plano.DataPropertyName = "path_plano";
            this.path_plano.HeaderText = "Ubicacion";
            this.path_plano.Name = "path_plano";
            this.path_plano.ReadOnly = true;
            // 
            // frmListarPlanos
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
            this.Controls.Add(this.dtgPlanos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(708, 389);
            this.Name = "frmListarPlanos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Planos";
            this.Load += new System.EventHandler(this.frmListarPlanos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPlanos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPlanos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cboProyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn revision;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_tipo_plano;
        private System.Windows.Forms.DataGridViewTextBoxColumn dibujadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn revisadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_plano;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_revision;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_envio;
        private System.Windows.Forms.DataGridViewTextBoxColumn path_plano;
    }
}