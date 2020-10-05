using BE._EFE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.PERSONA {
    public class PersonaADO {

        public List<PersonaEFE> ListarPersonasALL() {
            grubalEntities db = new grubalEntities();
            PersonaEFE p;
            List<PersonaEFE> list = new List<PersonaEFE>();
            try {
                var q = db.ListarPersonasALL();

                foreach (var r in q) {
                    p = new PersonaEFE(r.Id_Persona, r.Nombre);
                    list.Add(p);
                }
                return list;
            } catch (Exception ex) {
                throw new Exception("Error mostrando las personas: " + ex.Message);
            } 
            
        }
    }
}
