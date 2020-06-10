namespace GUI.PERSONA.CLIENTE {
    partial class frmNuevoCliente {
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.gbEmail = new System.Windows.Forms.GroupBox();
            this.txtEmailEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboEmailTipo = new System.Windows.Forms.ComboBox();
            this.gbTelefono = new System.Windows.Forms.GroupBox();
            this.txtTelCext = new System.Windows.Forms.TextBox();
            this.txtTelC3 = new System.Windows.Forms.TextBox();
            this.txtTelC2 = new System.Windows.Forms.TextBox();
            this.txtTelC1 = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboTelTipo = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInic = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.randomlabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboPerFuente = new System.Windows.Forms.ComboBox();
            this.cboPrInteres = new System.Windows.Forms.ComboBox();
            this.cboMarkContInic = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkTelefono = new System.Windows.Forms.CheckBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkDireccion = new System.Windows.Forms.CheckBox();
            this.gbPrincipal.SuspendLayout();
            this.gbDireccion.SuspendLayout();
            this.gbEmail.SuspendLayout();
            this.gbTelefono.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.txtDocumento);
            this.gbPrincipal.Controls.Add(this.txtNombre);
            this.gbPrincipal.Controls.Add(this.label2);
            this.gbPrincipal.Controls.Add(this.label1);
            this.gbPrincipal.Location = new System.Drawing.Point(12, 12);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(252, 78);
            this.gbPrincipal.TabIndex = 0;
            this.gbPrincipal.TabStop = false;
            this.gbPrincipal.Text = "Principal";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(74, 45);
            this.txtDocumento.MaxLength = 11;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Documento";
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
            this.gbDireccion.Location = new System.Drawing.Point(12, 96);
            this.gbDireccion.Name = "gbDireccion";
            this.gbDireccion.Size = new System.Drawing.Size(252, 244);
            this.gbDireccion.TabIndex = 1;
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
            // gbEmail
            // 
            this.gbEmail.Controls.Add(this.txtEmailEmail);
            this.gbEmail.Controls.Add(this.label10);
            this.gbEmail.Controls.Add(this.label11);
            this.gbEmail.Controls.Add(this.cboEmailTipo);
            this.gbEmail.Location = new System.Drawing.Point(270, 12);
            this.gbEmail.Name = "gbEmail";
            this.gbEmail.Size = new System.Drawing.Size(252, 78);
            this.gbEmail.TabIndex = 2;
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
            this.gbTelefono.Location = new System.Drawing.Point(270, 96);
            this.gbTelefono.Name = "gbTelefono";
            this.gbTelefono.Size = new System.Drawing.Size(252, 78);
            this.gbTelefono.TabIndex = 3;
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
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(438, 358);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 39);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 7;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtpFin);
            this.groupBox5.Controls.Add(this.dtpInic);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.randomlabel);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.cboPerFuente);
            this.groupBox5.Controls.Add(this.cboPrInteres);
            this.groupBox5.Controls.Add(this.cboMarkContInic);
            this.groupBox5.Location = new System.Drawing.Point(273, 180);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(252, 160);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Marketing";
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(59, 130);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(181, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // dtpInic
            // 
            this.dtpInic.Location = new System.Drawing.Point(59, 105);
            this.dtpInic.Name = "dtpInic";
            this.dtpInic.Size = new System.Drawing.Size(181, 20);
            this.dtpInic.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Cont. Inic.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Ultim. Con.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "P. Fuente";
            // 
            // randomlabel
            // 
            this.randomlabel.AutoSize = true;
            this.randomlabel.Location = new System.Drawing.Point(3, 54);
            this.randomlabel.Name = "randomlabel";
            this.randomlabel.Size = new System.Drawing.Size(55, 13);
            this.randomlabel.TabIndex = 0;
            this.randomlabel.Text = "Pr. Interés";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Cont. Inic.";
            // 
            // cboPerFuente
            // 
            this.cboPerFuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPerFuente.FormattingEnabled = true;
            this.cboPerFuente.Location = new System.Drawing.Point(59, 78);
            this.cboPerFuente.Name = "cboPerFuente";
            this.cboPerFuente.Size = new System.Drawing.Size(181, 21);
            this.cboPerFuente.TabIndex = 2;
            // 
            // cboPrInteres
            // 
            this.cboPrInteres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrInteres.FormattingEnabled = true;
            this.cboPrInteres.Location = new System.Drawing.Point(59, 49);
            this.cboPrInteres.Name = "cboPrInteres";
            this.cboPrInteres.Size = new System.Drawing.Size(181, 21);
            this.cboPrInteres.TabIndex = 1;
            // 
            // cboMarkContInic
            // 
            this.cboMarkContInic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarkContInic.FormattingEnabled = true;
            this.cboMarkContInic.Location = new System.Drawing.Point(59, 19);
            this.cboMarkContInic.Name = "cboMarkContInic";
            this.cboMarkContInic.Size = new System.Drawing.Size(181, 21);
            this.cboMarkContInic.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkTelefono);
            this.groupBox6.Controls.Add(this.chkEmail);
            this.groupBox6.Controls.Add(this.chkDireccion);
            this.groupBox6.Location = new System.Drawing.Point(211, 347);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(211, 50);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Opciones";
            // 
            // chkTelefono
            // 
            this.chkTelefono.AutoSize = true;
            this.chkTelefono.Checked = true;
            this.chkTelefono.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTelefono.Location = new System.Drawing.Point(140, 19);
            this.chkTelefono.Name = "chkTelefono";
            this.chkTelefono.Size = new System.Drawing.Size(68, 17);
            this.chkTelefono.TabIndex = 2;
            this.chkTelefono.Text = "Teléfono";
            this.chkTelefono.UseVisualStyleBackColor = true;
            this.chkTelefono.CheckedChanged += new System.EventHandler(this.chkTelefono_CheckedChanged);
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Checked = true;
            this.chkEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmail.Location = new System.Drawing.Point(83, 19);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(51, 17);
            this.chkEmail.TabIndex = 1;
            this.chkEmail.Text = "Email";
            this.chkEmail.UseVisualStyleBackColor = true;
            this.chkEmail.CheckedChanged += new System.EventHandler(this.chkEmail_CheckedChanged);
            // 
            // chkDireccion
            // 
            this.chkDireccion.AutoSize = true;
            this.chkDireccion.Checked = true;
            this.chkDireccion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDireccion.Location = new System.Drawing.Point(6, 19);
            this.chkDireccion.Name = "chkDireccion";
            this.chkDireccion.Size = new System.Drawing.Size(71, 17);
            this.chkDireccion.TabIndex = 0;
            this.chkDireccion.Text = "Dirección";
            this.chkDireccion.UseVisualStyleBackColor = true;
            this.chkDireccion.CheckedChanged += new System.EventHandler(this.chkDireccion_CheckedChanged);
            // 
            // frmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 409);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbDireccion);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbTelefono);
            this.Controls.Add(this.gbEmail);
            this.Controls.Add(this.gbPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.frmNuevoCliente_Load);
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.gbDireccion.ResumeLayout(false);
            this.gbDireccion.PerformLayout();
            this.gbEmail.ResumeLayout(false);
            this.gbEmail.PerformLayout();
            this.gbTelefono.ResumeLayout(false);
            this.gbTelefono.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDireccion;
        private System.Windows.Forms.ComboBox cboDirPais;
        private System.Windows.Forms.ComboBox cboDirProvincia;
        private System.Windows.Forms.ComboBox cboDirCiudad;
        private System.Windows.Forms.ComboBox cboDirDistrito;
        private System.Windows.Forms.ComboBox cboDirTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDirLinea2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDirLinea1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbEmail;
        private System.Windows.Forms.TextBox txtEmailEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboEmailTipo;
        private System.Windows.Forms.GroupBox gbTelefono;
        private System.Windows.Forms.TextBox txtTelCext;
        private System.Windows.Forms.TextBox txtTelC3;
        private System.Windows.Forms.TextBox txtTelC2;
        private System.Windows.Forms.TextBox txtTelC1;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboTelTipo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label randomlabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboMarkContInic;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInic;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboPrInteres;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboPerFuente;
        private System.Windows.Forms.TextBox txtDirPostal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkTelefono;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkDireccion;
    }
}