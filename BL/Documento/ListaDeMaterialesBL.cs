using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.DOCUMENTO;

namespace BL.Documento {
    class ListaDeMaterialesBL {
        ListaDeMaterialesBL lmat = new ListaDeMaterialesBL();



        public DataTable ListarMaterialesPorProyecto(int id_proyecto) {
            return lmat.ListarMaterialesPorProyecto(id_proyecto);
        }
    }
}
