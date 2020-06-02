using ADO.MarketingUTIL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.MarketingUTIL {
    public class ContactoInicialBL {
        ContactoInicialADO coin = new ContactoInicialADO();

        public DataTable ListarContactoInicial() {
            return coin.ListarContactoInicial();
        }
    }
}
