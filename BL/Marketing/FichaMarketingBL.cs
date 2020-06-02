using ADO.MARKETING;
using BE.MARKETING;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Marketing {
    public class FichaMarketingBL {
        
        FichaMarketingADO fmado = new FichaMarketingADO();
        public Boolean FichaMarketingNew(FichaMarketingBE fmbe) {
            return fmado.FichaMarketingNew(fmbe);
        }
    }
}
