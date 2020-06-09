using ADO.MarketingUTIL;
using ADO.PERSONA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.PersonaUTIL {
    public class PersonaBL {
        PersonaADO perado = new PersonaADO();
        public DataTable ListarPersonasALL() {
            return perado.ListarPersonasALL();
        }
    }
}
