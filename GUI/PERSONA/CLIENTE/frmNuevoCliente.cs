using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.UTIL;
using BE.PERSONA;
using BE.MARKETING;
using BL.MarketingUTIL;
using BL.PersonaUTIL;
using BL.Marketing;
using BL.Persona;

namespace GUI.PERSONA.CLIENTE {
    public partial class frmNuevoCliente : Form {
        public frmNuevoCliente() {
            InitializeComponent();
        }

        DireccionesBL dirs = new DireccionesBL();
        TelefonosBL tels = new TelefonosBL();
        EmailsBL emails = new EmailsBL();

        ContactoInicialBL contactoinicial = new ContactoInicialBL();
        PersonaFuenteBL personafuente = new PersonaFuenteBL();
        PrimerInteresBL primerinteres = new PrimerInteresBL(); 

        public void frmNuevoCliente_Load(object sender, EventArgs e) {
            //informacion direccion
            try {
                //Pais
                cboDirPais.DataSource = dirs.ListarPaises();
                cboDirPais.DisplayMember = "nom_pais";
                cboDirPais.ValueMember = "id_pais";

                //Tipos
                cboDirTipo.DataSource = dirs.ListarDireccionesTipos();
                cboDirTipo.DisplayMember = "nombre_direccion";
                cboDirTipo.ValueMember = "tipo_direccion";

            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de direccion : " + ex.Message);
            }

            
            //informacion telefono
            try {
                //tipo telefono
                cboTelTipo.DataSource = tels.ListarTelefonosTipos();
                cboTelTipo.DisplayMember = "nombre_telefono";
                cboTelTipo.ValueMember = "tipo_telefono";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de telefono : " + ex.Message);
            }
            
            //informacion email
            try {
                //tipo email
                cboEmailTipo.DataSource = emails.ListarEmailsTipos();
                cboEmailTipo.DisplayMember = "nombre_email";
                cboEmailTipo.ValueMember = "tipo_email";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de email : " + ex.Message);
            }

            //informacion marketing
            try {
                //Contacto inicia;
                cboMarkContInic.DataSource = contactoinicial.ListarContactoInicial();
                cboMarkContInic.DisplayMember = "nom_forma_contacto";
                cboMarkContInic.ValueMember = "id_contacto";

                //listar fuentes
                cboPerFuente.DataSource = personafuente.ListarEmpleados();
                cboPerFuente.DisplayMember = "primer_nom";
                cboPerFuente.ValueMember = "id_persona";

                //listar primer interes
                cboPrInteres.DataSource = primerinteres.ListarPrimerInteres();
                cboPrInteres.DisplayMember = "desc_primer_interes";
                cboPrInteres.ValueMember = "id_interes";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de marketing : " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            int idCliente;
            string strInserted = "Insertaste un cliente con: ";

            if (
                String.IsNullOrWhiteSpace(txtNombre.Text) &&
                String.IsNullOrWhiteSpace(txtEmailEmail.Text) &&
                String.IsNullOrWhiteSpace(txtDirLinea1.Text) &&
                String.IsNullOrWhiteSpace(txtTelC1.Text)
                ) {
                MessageBox.Show(this, "El formulario esta vacio.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (
                String.IsNullOrWhiteSpace(txtNombre.Text)
                ) {
                MessageBox.Show(this, "No puedes agregar un cliente sin nombre.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            // 1. Nuevo ID de Persona
            idCliente = NewPersonId();

            // 2. Nueva ficha Marketing
            NewFichaMarketing(idCliente);

            // 3. Nuevo Cliente
            NewCliente(idCliente);

            // 4. Llenar Direccion
            if (chkDireccion.Checked == true) {
                NewDireccion(idCliente);
                strInserted += " direccion, ";
            }

            // 5. Llenar Telefono
            if (chkTelefono.Checked == true) {
                NewTelefono(idCliente);
                strInserted += " telefono, ";
            }

            //6. Llenar Email
            if (chkEmail.Checked == true) {
                NewEmail(idCliente);
                strInserted += " email, ";
            }

            if (chkEmail.Checked == false && chkDireccion.Checked == false && chkTelefono.Checked == false)  { 
                strInserted += "una ficha marketing con id " + idCliente; } 
            else {
                strInserted += " y una ficha marketing con id " + idCliente;
            }

            MessageBox.Show(this, strInserted, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            return;
        }

        private int NewPersonId () {
            NewIdBL newid = new NewIdBL();
            int idPersona = newid.NewId();
            return idPersona;
        }

        private void NewFichaMarketing(int idCliente) {
            FichaMarketingBE fmBE = new FichaMarketingBE(
                idCliente,
                int.Parse(cboPerFuente.SelectedValue.ToString()),
                short.Parse(cboMarkContInic.SelectedValue.ToString()),
                short.Parse(cboPrInteres.SelectedValue.ToString()),
                dtpInic.Value,
                dtpFin.Value
                );
            FichaMarketingBL fmBL = new FichaMarketingBL();
            fmBL.FichaMarketingNew(fmBE);
        }

        private void NewCliente(int idCliente) {
            ClienteBE cBE = new ClienteBE(
                idCliente,
                idCliente,
                txtNombre.Text.Trim(),
                txtDocumento.Text.Trim()
                );
            ClienteBL clibe = new ClienteBL();
            clibe.ClienteNew(cBE);
        }

        private void NewDireccion(int idCliente) {
            DireccionBE dirbe = new DireccionBE(
                byte.Parse(cboDirTipo.SelectedValue.ToString()),
                idCliente,
                short.Parse(cboDirPais.SelectedValue.ToString()),
                int.Parse(cboDirProvincia.SelectedValue.ToString()),
                int.Parse(cboDirCiudad.SelectedValue.ToString()),
                int.Parse(cboDirDistrito.SelectedValue.ToString()),
                txtDirLinea1.Text.Trim(),
                txtDirLinea2.Text.Trim(),
                txtDirPostal.Text.Trim()
            );
            DireccionesBL dirbl = new DireccionesBL();
            dirbl.DireccionNew(dirbe);
        }

        private void NewTelefono(int idCliente) {
            TelefonoBE telbe = new TelefonoBE(
                short.Parse(cboTelTipo.SelectedValue.ToString()),
                idCliente,
                txtCP.Text.Trim(),
                txtTelC1.Text.Trim(),
                txtTelC2.Text.Trim(),
                txtTelC3.Text.Trim(),
                txtTelCext.Text.Trim()
                );
            TelefonosBL telBL = new TelefonosBL();
            telBL.TelefonoNew(telbe);
        }

        private void NewEmail(int idCliente) {
            EmailBE embe = new EmailBE(
                short.Parse(cboEmailTipo.SelectedValue.ToString()),
                idCliente,
                txtEmailEmail.Text.Trim()
                );
            EmailsBL emailBL = new EmailsBL();
            emailBL.EmailNew(embe);
        }

        private void cboDirPais_SelectionChangeCommitted(object sender, EventArgs e) {
            cboDirProvincia.DataSource = null;
            cboDirCiudad.DataSource = null;
            cboDirDistrito.DataSource = null;
            //Region
            try { 
            cboDirProvincia.DataSource = dirs.ListarRegionesPorIdPais((byte)cboDirPais.SelectedValue);
            cboDirProvincia.DisplayMember = "nom_region";
            cboDirProvincia.ValueMember = "id_region";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de direccion : " + ex.Message);
            }
        }

        private void cboDirProvincia_SelectionChangeCommitted(object sender, EventArgs e) {
            cboDirCiudad.DataSource = null;
            cboDirDistrito.DataSource = null;
            //Ciudad
            try { 
            cboDirCiudad.DataSource = dirs.ListarCiudadesPorIdRegion((int)cboDirProvincia.SelectedValue);
            cboDirCiudad.DisplayMember = "nom_ciudad";
            cboDirCiudad.ValueMember = "id_ciudad";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de direccion : " + ex.Message);
            }
        }

        private void cboDirCiudad_SelectionChangeCommitted(object sender, EventArgs e) {
            cboDirDistrito.DataSource = null;
            //Distrito
            try {
                cboDirDistrito.DataSource = dirs.ListarDistritosPorIdCiudad((int)cboDirCiudad.SelectedValue);
                cboDirDistrito.DisplayMember = "nom_distrito";
                cboDirDistrito.ValueMember = "id_distrito";
            } catch (Exception ex) {
                MessageBox.Show("Error al poblar opciones de direccion : " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            MessageBox.Show(this, "Si sale los cambios se eliminaran.", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }

        private void chkTelefono_CheckedChanged(object sender, EventArgs e) {
            if (chkTelefono.Checked) {
                gbTelefono.Enabled = true;
            } else {
                gbTelefono.Enabled = false;
            }
        }

        private void chkEmail_CheckedChanged(object sender, EventArgs e) {
            if (chkEmail.Checked) {
                gbEmail.Enabled = true;
            } else {
                gbEmail.Enabled = false;
            }
        }

        private void chkDireccion_CheckedChanged(object sender, EventArgs e) {
            if (chkDireccion.Checked) {
                gbDireccion.Enabled = true;
            } else {
                gbDireccion.Enabled = false;
            }
        }
    }
}
