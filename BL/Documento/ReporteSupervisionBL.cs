using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.DOCUMENTO;

namespace BL.Documento {
    public class ReporteSupervisionBL {
        ReporteSupervisionADO rsupADO = new ReporteSupervisionADO();
        public DataTable ListarReporteSupervisionProyectoSupervisor(int id_proyecto, int id_supervisor) {
            return rsupADO.ListarReporteSupervisionProyectoSupervisor(id_proyecto, id_supervisor);
        }

        public DataTable ListarReporteSupervisionFull() {
            return rsupADO.ListarReporteSupervisionFull();
        }
    }
}
