using ADO;
using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Persona {
    public class ClienteBL {
        ClienteADO cliado = new ClienteADO();
        ClienteBE clibe = new ClienteBE();
        public Boolean ClienteNew(ClienteBE clibe) {
            return cliado.ClienteNew(clibe);
        }

        public Boolean ModificarCliente(ClienteBE clibe) {
            return cliado.ModificarCliente(clibe);
        }

        public Boolean EliminarCliente(int idCliente, int idFichaMarketing) {
            return cliado.EliminarCliente(idCliente, idFichaMarketing);
        }

        public DataTable ListarClientes() {
            return cliado.ListarClientes();
        }

        public ClienteBE ListarClientesPorId(int idClinte) {
            return cliado.ListarClientesPorId(idClinte);
        }
    }
}
