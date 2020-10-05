using BE._EFE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.MarketingUTIL {
    public class PrimerInteresADO {

        public List<PrimerInteresEFE> ListarPrimerInteres() {
            grubalEntities db = new grubalEntities();
            PrimerInteresEFE p;
            List<PrimerInteresEFE> list = new List<PrimerInteresEFE>();
            try {
                var q = db.ListarPrimerInteres();

                foreach(var r in q) {
                    p = new PrimerInteresEFE(r.id_interes, r.desc_primer_interes);
                    list.Add(p);
                }
                return list;
            } catch (Exception ex) {
                throw new Exception("Error mostrando los tipos de Primer Interés: " + ex.Message);
            } 
        }
    }
}
