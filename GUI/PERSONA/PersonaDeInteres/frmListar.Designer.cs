namespace GUI.PERSONA.PersonaDeInteres {
    partial class frmListar {
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
            this.dtgPerInteres = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPerInteres)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPerInteres
            // 
            this.dtgPerInteres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPerInteres.Location = new System.Drawing.Point(12, 12);
            this.dtgPerInteres.Name = "dtgPerInteres";
            this.dtgPerInteres.Size = new System.Drawing.Size(776, 426);
            this.dtgPerInteres.TabIndex = 0;
            // 
            // frmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgPerInteres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListar";
            this.Text = "Listar Personas de Interes";
            this.Load += new System.EventHandler(this.frmListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPerInteres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPerInteres;
    }
}