using ADO;
using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Persona {
    public class ClienteBL {
        ClienteADO cliado = new ClienteADO();
        public Boolean ClienteNew(ClienteBE clibe) {
            return cliado.ClienteNew(clibe);
        }
    }
}
