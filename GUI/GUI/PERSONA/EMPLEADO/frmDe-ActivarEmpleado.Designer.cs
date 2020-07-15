namespace GUI.PERSONA.EMPLEADO {
    partial class frmDe_ActivarEmpleado {
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
            this.btnEstado = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBuscarEmpleado = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(13, 39);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(407, 51);
            this.btnEstado.TabIndex = 2;
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Empleado";
            // 
            // cboBuscarEmpleado
            // 
            this.cboBuscarEmpleado.FormattingEnabled = true;
            this.cboBuscarEmpleado.Location = new System.Drawing.Point(70, 12);
            this.cboBuscarEmpleado.Name = "cboBuscarEmpleado";
            this.cboBuscarEmpleado.Size = new System.Drawing.Size(269, 21);
            this.cboBuscarEmpleado.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(345, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(75, 23);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.UseVisualStyleBackColor = true;
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            // 
            // frmDe_ActivarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 100);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboBuscarEmpleado);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDe_ActivarEmpleado";
            this.Text = "De-/Activar Empleado";
            this.Load += new System.EventHandler(this.frmDe_ActivarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboBuscarEmpleado;
        private System.Windows.Forms.Button txtBuscar;
    }
}