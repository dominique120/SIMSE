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
                //Distrito
                cboDirDistrito.DataSource = dirs.ListarDistritos();
                cboDirDistrito.DisplayMember = "nom_distrito";
                cboDirDistrito.ValueMember = "id_distrito";

                //Ciudad
                cboDirCiudad.DataSource = dirs.ListarCiudades();
                cboDirCiudad.DisplayMember = "nom_ciudad";
                cboDirCiudad.ValueMember = "id_ciudad";

                //Region
                cboDirProvincia.DataSource = dirs.ListarRegiones();
                cboDirProvincia.DisplayMember = "nom_region";
                cboDirProvincia.ValueMember = "id_region";

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

            // 1. Nuevo ID de Persona
            NewIdBL newid = new NewIdBL();
            int idCliente = newid.NewId();

            // 2. Nueva ficha Marketing
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

            // 3. Nuevo Cliente
            ClienteBE cBE = new ClienteBE(
                idCliente,
                idCliente,
                txtNombre.Text.Trim(),
                txtDocumento.Text.Trim()
                );
            ClienteBL clibe = new ClienteBL();
            clibe.ClienteNew(cBE);

            // 4. Llenar Direccion
            DireccionBE dirbe = new DireccionBE(
                byte.Parse(cboDirTipo.SelectedValue.ToString()),
                idCliente,
                short.Parse(cboDirPais.SelectedValue.ToString()),
                int.Parse(cboDirProvincia.SelectedValue.ToString()),
                int.Parse(cboDirCiudad.SelectedValue.ToString()),
                int.Parse(cboDirDistrito.SelectedValue.ToString()),
                txtDirLinea1.Text.Trim(),
                txtDirLinea2.Text.Trim(),
                txtCP.Text.Trim()
            );
            DireccionesBL dirbl = new DireccionesBL();
            dirbl.DireccionNew(dirbe);

            // 5. Llenar Telefono
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

            //6. Llenar Email
            EmailBE embe = new EmailBE(
                short.Parse(cboEmailTipo.SelectedValue.ToString()),
                idCliente,
                txtEmailEmail.Text.Trim()
                );
            EmailsBL emailBL = new EmailsBL();
            emailBL.EmailNew(embe);

            MessageBox.Show("Se ingreso la informacion correctamente");
        }
    }
}
