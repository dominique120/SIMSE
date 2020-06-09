namespace GUI.PERSONA.UTIL.Direcciones {
    partial class frmNewDireccion {
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
            this.gbDireccion = new System.Windows.Forms.GroupBox();
            this.cboDirPais = new System.Windows.Forms.ComboBox();
            this.cboDirProvincia = new System.Windows.Forms.ComboBox();
            this.cboDirCiudad = new System.Windows.Forms.ComboBox();
            this.cboDirDistrito = new System.Windows.Forms.ComboBox();
            this.cboDirTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDirPostal = new System.Windows.Forms.TextBox();
            this.txtDirLinea2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDirLinea1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboPersonas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDireccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDireccion
            // 
            this.gbDireccion.Controls.Add(this.cboDirPais);
            this.gbDireccion.Controls.Add(this.cboDirProvincia);
            this.gbDireccion.Controls.Add(this.cboDirCiudad);
            this.gbDireccion.Controls.Add(this.cboDirDistrito);
            this.gbDireccion.Controls.Add(this.cboDirTipo);
            this.gbDireccion.Controls.Add(this.label8);
            this.gbDireccion.Controls.Add(this.label7);
            this.gbDireccion.Controls.Add(this.label9);
            this.gbDireccion.Controls.Add(this.txtDirPostal);
            this.gbDireccion.Controls.Add(this.txtDirLinea2);
            this.gbDireccion.Controls.Add(this.label6);
            this.gbDireccion.Controls.Add(this.txtDirLinea1);
            this.gbDireccion.Controls.Add(this.label18);
            this.gbDireccion.Controls.Add(this.label5);
            this.gbDireccion.Controls.Add(this.label3);
            this.gbDireccion.Controls.Add(this.label4);
            this.gbDireccion.Location = new System.Drawing.Point(12, 52);
            this.gbDireccion.Name = "gbDireccion";
            this.gbDireccion.Size = new System.Drawing.Size(252, 244);
            this.gbDireccion.TabIndex = 2;
            this.gbDireccion.TabStop = false;
            this.gbDireccion.Text = "Dirección";
            // 
            // cboDirPais
            // 
            this.cboDirPais.FormattingEnabled = true;
            this.cboDirPais.Location = new System.Drawing.Point(74, 98);
            this.cboDirPais.Name = "cboDirPais";
            this.cboDirPais.Size = new System.Drawing.Size(169, 21);
            this.cboDirPais.TabIndex = 3;
            this.cboDirPais.SelectionChangeCommitted += new System.EventHandler(this.cboDirPais_SelectionChangeCommitted);
            // 
            // cboDirProvincia
            // 
            this.cboDirProvincia.FormattingEnabled = true;
            this.cboDirProvincia.Location = new System.Drawing.Point(74, 125);
            this.cboDirProvincia.Name = "cboDirProvincia";
            this.cboDirProvincia.Size = new System.Drawing.Size(169, 21);
            this.cboDirProvincia.TabIndex = 4;
            this.cboDirProvincia.SelectionChangeCommitted += new System.EventHandler(this.cboDirProvincia_SelectionChangeCommitted);
            // 
            // cboDirCiudad
            // 
            this.cboDirCiudad.FormattingEnabled = true;
            this.cboDirCiudad.Location = new System.Drawing.Point(74, 154);
            this.cboDirCiudad.Name = "cboDirCiudad";
            this.cboDirCiudad.Size = new System.Drawing.Size(169, 21);
            this.cboDirCiudad.TabIndex = 5;
            this.cboDirCiudad.SelectionChangeCommitted += new System.EventHandler(this.cboDirCiudad_SelectionChangeCommitted);
            // 
            // cboDirDistrito
            // 
            this.cboDirDistrito.FormattingEnabled = true;
            this.cboDirDistrito.Location = new System.Drawing.Point(74, 181);
            this.cboDirDistrito.Name = "cboDirDistrito";
            this.cboDirDistrito.Size = new System.Drawing.Size(169, 21);
            this.cboDirDistrito.TabIndex = 6;
            // 
            // cboDirTipo
            // 
            this.cboDirTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDirTipo.FormattingEnabled = true;
            this.cboDirTipo.Location = new System.Drawing.Point(74, 71);
            this.cboDirTipo.Name = "cboDirTipo";
            this.cboDirTipo.Size = new System.Drawing.Size(169, 21);
            this.cboDirTipo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "País:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Provincia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ciudad:";
            // 
            // txtDirPostal
            // 
            this.txtDirPostal.Location = new System.Drawing.Point(74, 208);
            this.txtDirPostal.Name = "txtDirPostal";
            this.txtDirPostal.Size = new System.Drawing.Size(169, 20);
            this.txtDirPostal.TabIndex = 7;
            // 
            // txtDirLinea2
            // 
            this.txtDirLinea2.Location = new System.Drawing.Point(74, 45);
            this.txtDirLinea2.Name = "txtDirLinea2";
            this.txtDirLinea2.Size = new System.Drawing.Size(169, 20);
            this.txtDirLinea2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Distrito:";
            // 
            // txtDirLinea1
            // 
            this.txtDirLinea1.Location = new System.Drawing.Point(75, 19);
            this.txtDirLinea1.Name = "txtDirLinea1";
            this.txtDirLinea1.Size = new System.Drawing.Size(168, 20);
            this.txtDirLinea1.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 211);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "C. Postal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Linea 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Linea 1:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(189, 302);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboPersonas
            // 
            this.cboPersonas.FormattingEnabled = true;
            this.cboPersonas.Location = new System.Drawing.Point(12, 25);
            this.cboPersonas.Name = "cboPersonas";
            this.cboPersonas.Size = new System.Drawing.Size(242, 21);
            this.cboPersonas.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Persona";
            // 
            // frmNewDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPersonas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbDireccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewDireccion";
            this.Text = "Nueva Direccion";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmNewDireccion_Load);
            this.gbDireccion.ResumeLayout(false);
            this.gbDireccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDireccion;
        private System.Windows.Forms.ComboBox cboDirPais;
        private System.Windows.Forms.ComboBox cboDirProvincia;
        private System.Windows.Forms.ComboBox cboDirCiudad;
        private System.Windows.Forms.ComboBox cboDirDistrito;
        private System.Windows.Forms.ComboBox cboDirTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDirPostal;
        private System.Windows.Forms.TextBox txtDirLinea2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDirLinea1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cboPersonas;
        private System.Windows.Forms.Label label1;
    }
}