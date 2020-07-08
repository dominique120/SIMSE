using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.DOCUMENTO;
namespace BL.Documento {
    public class ReportesTecnicosBL {

        ReporteTecnicoADO rtec = new ReporteTecnicoADO();

        public DataTable ListarReporteTecnicoPorProyectoEmpleado(int id_proyecto, int id_tecnico) {
            return rtec.ListarReporteTecnicoPorProyectoEmpleado(id_proyecto, id_tecnico);
        }
        public DataTable ListarReporteTecnicoFull() {
            return rtec.ListarReporteTecnicoFull();
        }
    }
}
