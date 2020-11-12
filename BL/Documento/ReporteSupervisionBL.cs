using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.DOCUMENTO;
using BE.DOCUMENTO;

namespace BL.Documento {
    public class ReporteSupervisionBL {
        ReporteSupervisionADO rsupADO = new ReporteSupervisionADO();
        public DataTable ListarReporteSupervisionProyectoSupervisor(int id_proyecto, int id_supervisor) {
            return rsupADO.ListarReporteSupervisionProyectoSupervisor(id_proyecto, id_supervisor);
        }

        public DataTable ListarReporteSupervisionFull() {
            return rsupADO.ListarReporteSupervisionFull();
        }
        public ReporteSupervisionBE ListarReporteSupervisionPorId(int idDocumento) {
            return rsupADO.ListarReporteSupervisionPorId(idDocumento);
        }
        public DataTable ListarReporteSupervisionProyecto(int id_proyecto) {
            return rsupADO.ListarReporteSupervisionProyecto(id_proyecto);
        }

        public Boolean ReporteSupervisionNew(ReporteSupervisionBE rsBE) {
            return rsupADO.ReporteSupervisionNew(rsBE);
        }

        public Boolean EliminarReporteSupervision(int idDocumento) {
            return rsupADO.EliminarReporteSupervision(idDocumento);
        }

        public Boolean ModificarReporteSupervision(ReporteSupervisionBE rsBE) {
            return rsupADO.ModificarReporteSupervision(rsBE);
        }
    }
}
