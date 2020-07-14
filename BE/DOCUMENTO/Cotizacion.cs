using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.DOCUMENTO {
    public class CotizacionBE {

        private int id_documento;
        private int id_proyecto;
        private int id_encargado;
        private int id_aprobado_por;
        private int enviar_a;
        private DateTime fecha_aprobacion;
        private DateTime fecha_creacion;
        private DateTime fecha_envio;
        private float valor_total;
        private string notas;
        private string path_archivo;
        private DataTable detalleDeCotizacion;

        public int Id_documento { get => id_documento; set => id_documento = value; }
        public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
        public int Id_encargado { get => id_encargado; set => id_encargado = value; }
        public int Id_aprobado_por { get => id_aprobado_por; set => id_aprobado_por = value; }
        public int Enviar_a { get => enviar_a; set => enviar_a = value; }
        public DateTime Fecha_aprobacion { get => fecha_aprobacion; set => fecha_aprobacion = value; }
        public DateTime Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        public DateTime Fecha_envio { get => fecha_envio; set => fecha_envio = value; }
        public float Valor_total { get => valor_total; set => valor_total = value; }
        public string Notas { get => notas; set => notas = value; }
        public string Path_archivo { get => path_archivo; set => path_archivo = value; }
        public DataTable DetalleDeCotizacion { get => detalleDeCotizacion; set => detalleDeCotizacion = value; }

        public CotizacionBE(int id_documento, int id_proyecto, int id_encargado, int id_aprobado_por, int enviar_a, DateTime fecha_aprobacion, DateTime fecha_creacion, DateTime fecha_envio, float valor_total, string notas, string path_archivo, DataTable detalleDeCotizacion) {
            this.Id_documento = id_documento;
            this.Id_proyecto = id_proyecto;
            this.Id_encargado = id_encargado;
            this.Id_aprobado_por = id_aprobado_por;
            this.Enviar_a = enviar_a;
            this.Fecha_aprobacion = fecha_aprobacion;
            this.Fecha_creacion = fecha_creacion;
            this.Fecha_envio = fecha_envio;
            this.Valor_total = valor_total;
            this.Notas = notas;
            this.Path_archivo = path_archivo;
            this.DetalleDeCotizacion = detalleDeCotizacion;
        }
    }
}
