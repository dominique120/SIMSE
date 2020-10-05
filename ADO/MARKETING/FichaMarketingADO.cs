using BE.MARKETING;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.MARKETING {
    public class FichaMarketingADO {
        grubalEntities db = new grubalEntities();
        Boolean success = false;

        public Boolean FichaMarketingNew(FichaMarketingBE f) {
            try {
                db.FichaMarketingNew(f.Id_ficha_marketing, f.Id_persona_fuente, f.Forma_contacto_inical, f.Primer_interes, f.Fecha_primer_contacto, f.Fecha_ultimo_contacto);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;

        }
    }
}
