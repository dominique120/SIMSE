using ADO.INVENTARIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Inventario {
    public class ArticuloBL {
        ArticuloADO aADO = new ArticuloADO();

        public DataTable ListarArticulos() {
            return aADO.ListarArticulos();
        }
    }
}
