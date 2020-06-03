namespace GUI.PROYECTO
{
    partial class frmNuevoProyecto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboDirPais = new System.Windows.Forms.ComboBox();
            this.cboDirProvincia = new System.Windows.Forms.ComboBox();
            this.cboDirCiudad = new System.Windows.Forms.ComboBox();
            this.cboDirDistrito = new System.Windows.Forms.ComboBox();
            this.cboDirTipo = new System.Windows.Forms.ComboBox();
            this.txtDirLinea2 = new System.Windows.Forms.TextBox();
            this.txtDirLinea1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpFecIni);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Principal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-1, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Fecha Inicio:";
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(73, 57);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(178, 20);
            this.dtpFecIni.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboDirPais);
            this.groupBox2.Controls.Add(this.cboDirProvincia);
            this.groupBox2.Controls.Add(this.cboDirCiudad);
            this.groupBox2.Controls.Add(this.cboDirDistrito);
            this.groupBox2.Controls.Add(this.cboDirTipo);
            this.groupBox2.Controls.Add(this.txtDirLinea2);
            this.groupBox2.Controls.Add(this.txtDirLinea1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Direccion";
            // 
            // cboDirPais
            // 
            this.cboDirPais.FormattingEnabled = true;
            this.cboDirPais.Location = new System.Drawing.Point(73, 256);
            this.cboDirPais.Name = "cboDirPais";
            this.cboDirPais.Size = new System.Drawing.Size(178, 21);
            this.cboDirPais.TabIndex = 13;
            // 
            // cboDirProvincia
            // 
            this.cboDirProvincia.FormattingEnabled = true;
            this.cboDirProvincia.Location = new System.Drawing.Point(73, 214);
            this.cboDirProvincia.Name = "cboDirProvincia";
            this.cboDirProvincia.Size = new System.Drawing.Size(178, 21);
            this.cboDirProvincia.TabIndex = 11;
            // 
            // cboDirCiudad
            // 
            this.cboDirCiudad.FormattingEnabled = true;
            this.cboDirCiudad.Location = new System.Drawing.Point(73, 175);
            this.cboDirCiudad.Name = "cboDirCiudad";
            this.cboDirCiudad.Size = new System.Drawing.Size(178, 21);
            this.cboDirCiudad.TabIndex = 9;
            // 
            // cboDirDistrito
            // 
            this.cboDirDistrito.FormattingEnabled = true;
            this.cboDirDistrito.Location = new System.Drawing.Point(73, 139);
            this.cboDirDistrito.Name = "cboDirDistrito";
            this.cboDirDistrito.Size = new System.Drawing.Size(178, 21);
            this.cboDirDistrito.TabIndex = 7;
            // 
            // cboDirTipo
            // 
            this.cboDirTipo.FormattingEnabled = true;
            this.cboDirTipo.Location = new System.Drawing.Point(73, 101);
            this.cboDirTipo.Name = "cboDirTipo";
            this.cboDirTipo.Size = new System.Drawing.Size(178, 21);
            this.cboDirTipo.TabIndex = 5;
            // 
            // txtDirLinea2
            // 
            this.txtDirLinea2.Location = new System.Drawing.Point(73, 64);
            this.txtDirLinea2.Name = "txtDirLinea2";
            this.txtDirLinea2.Size = new System.Drawing.Size(178, 20);
            this.txtDirLinea2.TabIndex = 3;
            // 
            // txtDirLinea1
            // 
            this.txtDirLinea1.Location = new System.Drawing.Point(73, 29);
            this.txtDirLinea1.Name = "txtDirLinea1";
            this.txtDirLinea1.Size = new System.Drawing.Size(178, 20);
            this.txtDirLinea1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Pais:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Provincia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ciudad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Distrito:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Linea 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Linea 1:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(294, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 93);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // frmNuevoProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 492);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNuevoProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmNuevoProyecto";
            this.Load += new System.EventHandler(this.frmNuevoProyecto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDirLinea1;
        private System.Windows.Forms.TextBox txtDirLinea2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboDirPais;
        private System.Windows.Forms.ComboBox cboDirProvincia;
        private System.Windows.Forms.ComboBox cboDirCiudad;
        private System.Windows.Forms.ComboBox cboDirDistrito;
        private System.Windows.Forms.ComboBox cboDirTipo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}