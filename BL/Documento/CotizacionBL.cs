using ADO.DOCUMENTO;
using BE.DOCUMENTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Documento {
    public class CotizacionBL {
        CotizacionADO cotADO = new CotizacionADO();
        public String CotizacionConDetallesNew(CotizacionBE cotBE) {
            return cotADO.CotizacionConDetallesNew(cotBE);
        }

        public DataTable ListarCotizacionesPorProyecto(int id_proyecto) {
            return cotADO.ListarCotizacionesPorProyecto(id_proyecto);
        }

    }
}
