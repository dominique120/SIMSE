using ADO.MarketingUTIL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.MarketingUTIL {
    public class PrimerInteresBL {
        PrimerInteresADO prin = new PrimerInteresADO();

        public DataTable ListarPrimerInteres() {
            return prin.ListarPrimerInteres();
        }
    }
}
