using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.DOCUMENTO {
    public class EntregaFinalBE {

        private int id_documento;
        private int id_proyecto;
        private int id_encargado;
        private string path_scan_reporte;
        private DateTime fecha;

        public EntregaFinalBE(int id_documento, int id_proyecto, int id_encargado, string path_scan_reporte, DateTime fecha) {
            this.id_documento = id_documento;
            this.id_proyecto = id_proyecto;
            this.id_encargado = id_encargado;
            this.path_scan_reporte = path_scan_reporte;
            this.fecha = fecha;
        }

        public int Id_documento { get => id_documento; set => id_documento = value; }
        public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
        public int Id_encargado { get => id_encargado; set => id_encargado = value; }
        public string Path_scan_reporte { get => path_scan_reporte; set => path_scan_reporte = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
