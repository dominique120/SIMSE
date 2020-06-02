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

        public Boolean EmailNew(EmailBE emailbe) {
            return email.EmailNew(emailbe);
        }

    }
}
