using ADO.MarketingUTIL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.MarketingUTIL {
    public class PersonaFuenteBL {
        PersonaFuenteADO pfa = new PersonaFuenteADO();

        public DataTable ListarEmpleados() {
            return pfa.ListarEmpleados();
        }
    }
}
