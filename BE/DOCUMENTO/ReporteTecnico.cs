using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.DOCUMENTO {
    public class ReporteTecnicoBE {
        private int id_documento;
        private int id_proyecto;
        private int id_tecnico;
        private DateTime fecha_reporte;
        private string detalles_reporte;
        private string path_scan_reporte;

        public int Id_documento { get => id_documento; set => id_documento = value; }
        public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
        public int Id_tecnico { get => id_tecnico; set => id_tecnico = value; }
        public DateTime Fecha_reporte { get => fecha_reporte; set => fecha_reporte = value; }
        public string Detalles_reporte { get => detalles_reporte; set => detalles_reporte = value; }
        public string Path_scan_reporte { get => path_scan_reporte; set => path_scan_reporte = value; }

        public ReporteTecnicoBE(int id_documento, int id_proyecto, int id_tecnico, DateTime fecha_reporte, string detalles_reporte, string path_scan_reporte) {
            this.Id_documento = id_documento;
            this.Id_proyecto = id_proyecto;
            this.Id_tecnico = id_tecnico;
            this.Fecha_reporte = fecha_reporte;
            this.Detalles_reporte = detalles_reporte;
            this.Path_scan_reporte = path_scan_reporte;
        }
    }
}
