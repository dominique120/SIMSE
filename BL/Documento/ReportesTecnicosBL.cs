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
        public DataTable ListarReporteTecnicoProyecto(int id_proyecto) {
            return rtec.ListarReporteTecnicoProyecto(id_proyecto);
        }

        public Boolean EliminarReporteTecnico(int idDocumento) {
            return rtec.EliminarReporteTecnico(idDocumento);
        }
    }
}