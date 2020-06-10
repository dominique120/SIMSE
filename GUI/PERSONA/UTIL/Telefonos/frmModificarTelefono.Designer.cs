namespace GUI.PERSONA.UTIL.Telefonos {
    partial class frmModificarTelefono {
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
            this.gbTelefono = new System.Windows.Forms.GroupBox();
            this.txtTelCext = new System.Windows.Forms.TextBox();
            this.txtTelC3 = new System.Windows.Forms.TextBox();
            this.txtTelC2 = new System.Windows.Forms.TextBox();
            this.txtTelC1 = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboTelTipo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbTelefono.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTelefono
            // 
            this.gbTelefono.Controls.Add(this.txtTelCext);
            this.gbTelefono.Controls.Add(this.txtTelC3);
            this.gbTelefono.Controls.Add(this.txtTelC2);
            this.gbTelefono.Controls.Add(this.txtTelC1);
            this.gbTelefono.Controls.Add(this.txtCP);
            this.gbTelefono.Controls.Add(this.label12);
            this.gbTelefono.Controls.Add(this.label13);
            this.gbTelefono.Controls.Add(this.cboTelTipo);
            this.gbTelefono.Location = new System.Drawing.Point(12, 12);
            this.gbTelefono.Name = "gbTelefono";
            this.gbTelefono.Size = new System.Drawing.Size(252, 78);
            this.gbTelefono.TabIndex = 4;
            this.gbTelefono.TabStop = false;
            this.gbTelefono.Text = "Teléfono";
            // 
            // txtTelCext
            // 
            this.txtTelCext.Location = new System.Drawing.Point(208, 19);
            this.txtTelCext.Name = "txtTelCext";
            this.txtTelCext.Size = new System.Drawing.Size(30, 20);
            this.txtTelCext.TabIndex = 4;
            // 
            // txtTelC3
            // 
            this.txtTelC3.Location = new System.Drawing.Point(172, 19);
            this.txtTelC3.Name = "txtTelC3";
            this.txtTelC3.Size = new System.Drawing.Size(30, 20);
            this.txtTelC3.TabIndex = 3;
            // 
            // txtTelC2
            // 
            this.txtTelC2.Location = new System.Drawing.Point(136, 19);
            this.txtTelC2.Name = "txtTelC2";
            this.txtTelC2.Size = new System.Drawing.Size(30, 20);
            this.txtTelC2.TabIndex = 2;
            // 
            // txtTelC1
            // 
            this.txtTelC1.Location = new System.Drawing.Point(100, 19);
            this.txtTelC1.Name = "txtTelC1";
            this.txtTelC1.Size = new System.Drawing.Size(30, 20);
            this.txtTelC1.TabIndex = 1;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(64, 19);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(30, 20);
            this.txtCP.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tipo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Teléfono:";
            // 
            // cboTelTipo
            // 
            this.cboTelTipo.FormattingEnabled = true;
            this.cboTelTipo.Location = new System.Drawing.Point(62, 45);
            this.cboTelTipo.Name = "cboTelTipo";
            this.cboTelTipo.Size = new System.Drawing.Size(181, 21);
            this.cboTelTipo.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmModificarTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 140);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbTelefono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModificarTelefono";
            this.Text = "Modificar Teléfono";
            this.Load += new System.EventHandler(this.frmModificarTelefono_Load);
            this.gbTelefono.ResumeLayout(false);
            this.gbTelefono.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTelefono;
        private System.Windows.Forms.TextBox txtTelCext;
        private System.Windows.Forms.TextBox txtTelC3;
        private System.Windows.Forms.TextBox txtTelC2;
        private System.Windows.Forms.TextBox txtTelC1;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboTelTipo;
        private System.Windows.Forms.Button button1;
    }
}