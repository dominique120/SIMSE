namespace GUI.PERSONA.UTIL.Emails {
    partial class frmNewEmail {
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
            this.gbEmail = new System.Windows.Forms.GroupBox();
            this.txtEmailEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboEmailTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPersonas = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEmail
            // 
            this.gbEmail.Controls.Add(this.txtEmailEmail);
            this.gbEmail.Controls.Add(this.label10);
            this.gbEmail.Controls.Add(this.label11);
            this.gbEmail.Controls.Add(this.cboEmailTipo);
            this.gbEmail.Location = new System.Drawing.Point(12, 52);
            this.gbEmail.Name = "gbEmail";
            this.gbEmail.Size = new System.Drawing.Size(252, 78);
            this.gbEmail.TabIndex = 3;
            this.gbEmail.TabStop = false;
            this.gbEmail.Text = "Email";
            // 
            // txtEmailEmail
            // 
            this.txtEmailEmail.Location = new System.Drawing.Point(65, 19);
            this.txtEmailEmail.Name = "txtEmailEmail";
            this.txtEmailEmail.Size = new System.Drawing.Size(178, 20);
            this.txtEmailEmail.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tipo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Email:";
            // 
            // cboEmailTipo
            // 
            this.cboEmailTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmailTipo.FormattingEnabled = true;
            this.cboEmailTipo.Location = new System.Drawing.Point(64, 45);
            this.cboEmailTipo.Name = "cboEmailTipo";
            this.cboEmailTipo.Size = new System.Drawing.Size(179, 21);
            this.cboEmailTipo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Persona";
            // 
            // cboPersonas
            // 
            this.cboPersonas.FormattingEnabled = true;
            this.cboPersonas.Location = new System.Drawing.Point(12, 25);
            this.cboPersonas.Name = "cboPersonas";
            this.cboPersonas.Size = new System.Drawing.Size(243, 21);
            this.cboPersonas.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(189, 136);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmNewEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 170);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPersonas);
            this.Controls.Add(this.gbEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewEmail";
            this.Text = "Nuevo Email";
            this.Load += new System.EventHandler(this.frnNewEmail_Load);
            this.gbEmail.ResumeLayout(false);
            this.gbEmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEmail;
        private System.Windows.Forms.TextBox txtEmailEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboEmailTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPersonas;
        private System.Windows.Forms.Button btnGuardar;
    }
}