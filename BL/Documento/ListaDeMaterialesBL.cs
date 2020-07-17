using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.DOCUMENTO;
using BE.DOCUMENTO;

namespace BL.Documento {
    public class ListaDeMaterialesBL {
        ListaDeMaterialesADO lmat = new ListaDeMaterialesADO();

        public DataTable ListarMaterialesPorProyecto(int id_proyecto) {
            return lmat.ListarMaterialesPorProyecto(id_proyecto);
        }

        public int ListaMaterialesConDetallesNew(ListaDeMaterialesBE matBE) {
            return lmat.ListaMaterialesConDetallesNew(matBE);
        }
    }
}
