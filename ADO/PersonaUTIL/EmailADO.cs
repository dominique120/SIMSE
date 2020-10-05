using BE._EFE;
using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.PersonaUTIL {
    public class EmailADO {
        grubalEntities db = new grubalEntities();

        public List<EmailsTiposEFE> ListarEmailsTipos() {
            EmailsTiposEFE e;
            List<EmailsTiposEFE> list = new List<EmailsTiposEFE>();
            try {
                var q = db.ListarEmailsTipos();

                foreach (var r in q) {
                    e = new EmailsTiposEFE(r.nombre_email, r.tipo_email);
                    list.Add(e);
                }
                return list;

            } catch (Exception ex) {
                throw new Exception("Error mostrando los tipos de email: " + ex.Message);
            }
        }

        Boolean success = false;
        public Boolean EmailNew(EmailBE e) {
            try {
                db.EmailNew((byte)e.Tipo_email, e.Id_persona, e.Direccion_email);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;
        }

        public List<EmailBE> ListarEmailsFull()
        {
            EmailBE e;
            List<EmailBE> list = new List<EmailBE>();
            try
            {
                var q = db.ListarEmailsFull();
                foreach (var r in q) {
                    e = new EmailBE((byte)r.tipo_email, (int)r.Id_Persona, r.Email);
                    list.Add(e);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Error mostrando los emails: " + ex.Message);
            } 
        }

        public List<EmailBE> ListarEmailsFullPorId(int idPersona)
        {
            EmailBE e;
            List<EmailBE> list = new List<EmailBE>();
            try {
                var q = db.ListarEmailsFullPorId(idPersona);
                foreach (var r in q) {
                    e = new EmailBE((byte)r.tipo_email, (int)r.Id_Persona, r.Email);
                    list.Add(e);
                }
                return list;

            }
            catch (Exception ex)
            {
                throw new Exception("Error mostrando los email: " + ex.Message);
            } 
        }

        public EmailBE SelectEmail(int id_email) {
            EmailBE e = new EmailBE();
            try {
                var q = db.SelectEmail(id_email).FirstOrDefault();

                e = new EmailBE(q.tipo_email, q.id_persona, q.direccion_email);
                return e;
            } catch (Exception ex) {
                throw new Exception("Error mostrando los emails: " + ex.Message);
            } 
        }

        public bool ModificarEmail(EmailBE e) {
            try {
                db.ModificarEmail((byte)e.Tipo_email, e.Id_email, e.Id_persona, e.Direccion_email);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;
        }

        public Boolean EliminarEmail(int idEmail) {
            try {
                db.EliminarEmail(idEmail);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            }
            return success;
        }
    }
}
