using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.DOCUMENTO {
    public class PlanoBE {

        private int id_documento;
        private int id_proyecto;
        private string revision;
        private int tipo_plano;
        private int dibujado_por;
        private int revisado_por;
        private string nom_plano;
        private DateTime fecha_creacion;
        private DateTime fecha_revision;
        private DateTime fecha_envio;
        private string path_plano;

        public int Id_documento { get => id_documento; set => id_documento = value; }
        public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
        public string Revision { get => revision; set => revision = value; }
        public int Tipo_plano { get => tipo_plano; set => tipo_plano = value; }
        public int Dibujado_por { get => dibujado_por; set => dibujado_por = value; }
        public int Revisado_por { get => revisado_por; set => revisado_por = value; }
        public string Nom_plano { get => nom_plano; set => nom_plano = value; }
        public DateTime Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        public DateTime Fecha_revision { get => fecha_revision; set => fecha_revision = value; }
        public DateTime Fecha_envio { get => fecha_envio; set => fecha_envio = value; }
        public string Path_plano { get => path_plano; set => path_plano = value; }

        public PlanoBE(int id_documento, int id_proyecto, string revision, int tipo_plano, int dibujado_por, int revisado_por, string nom_plano, DateTime fecha_creacion, DateTime fecha_revision, DateTime fecha_envio, string path_plano) {
            this.Id_documento = id_documento;
            this.Id_proyecto = id_proyecto;
            this.Revision = revision;
            this.Tipo_plano = tipo_plano;
            this.Dibujado_por = dibujado_por;
            this.Revisado_por = revisado_por;
            this.Nom_plano = nom_plano;
            this.Fecha_creacion = fecha_creacion;
            this.Fecha_revision = fecha_revision;
            this.Fecha_envio = fecha_envio;
            this.Path_plano = path_plano;
        }
    }
}
