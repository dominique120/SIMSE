using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.DOCUMENTO;
using BE.DOCUMENTO;

namespace BL.Documento {
    public class ReportesTecnicosBL {

        ReporteTecnicoADO rtec = new ReporteTecnicoADO();

        public DataTable ListarReporteTecnicoPorProyectoEmpleado(int id_proyecto, int id_tecnico) {
            return rtec.ListarReporteTecnicoPorProyectoEmpleado(id_proyecto, id_tecnico);
        }
        public DataTable ListarReporteTecnicoFull() {
            return rtec.ListarReporteTecnicoFull();
        }

        public Boolean ReporteTecnicoNew(ReporteTecnicoBE rtBE) {
            return rtec.ReporteTecnicoNew(rtBE);
        }

        public Boolean EliminarReporteTecnico(int idDocumento) {
            return rtec.EliminarReporteTecnico(idDocumento);
        }

        public Boolean ModificarReporteTecnico(ReporteTecnicoBE rtBE) {
            return rtec.ModificarReporteTecnico(rtBE);
        }

    }
}