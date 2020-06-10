using ADO.PersonaUTIL;
using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.UTIL {
    public class EmailsBL {

        EmailADO email = new EmailADO();

        public DataTable ListarEmailsTipos() {
            return email.ListarEmailsTipos();
        }
        public Boolean EliminarEmail(int idEmail) {
            return email.EliminarEmail(idEmail);
        }

        public bool ModificarEmail(EmailBE emailBE) {
            return email.ModificarEmail(emailBE);
        }

        public EmailBE SelectEmail(int id_email) {
            return email.SelectEmail(id_email);
        }

        public Boolean EmailNew(EmailBE emailbe) {
            return email.EmailNew(emailbe);
        }
        public DataTable ListarEmailsFull()
        {
            return email.ListarEmailsFull();
        }
        public DataTable ListarEmailsFullPorId(int idPersona)
        {
            return email.ListarEmailsFullPorId(idPersona);
        }
    }
}
