using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.PersonaUTIL {
    public class NewIdADO {
        grubalEntities db = new grubalEntities();

        public int NewId() {
            int newid = 0;
            try {
                // TODO: This is suposer to return a parameter(it does)
                // but it also expects one and its not suposed to receive one
                // db.NewPerson();

            } catch (Exception ex) {
                throw new Exception("Error generando nuevo Id de persona: " + ex.Message);
            }
            return newid;
        }
    }
}

