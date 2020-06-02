using ADO.PersonaUTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.PersonaUTIL {
    public class NewIdBL {

        NewIdADO newid = new NewIdADO();

        public int NewId() {
            return newid.NewId();
        }
    }
}
