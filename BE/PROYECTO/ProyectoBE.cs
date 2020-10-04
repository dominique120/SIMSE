using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.PROYECTO
{
    public class ProyectoBE
    {
        private int id_proyecto;
        private int id_cliente;
        private int id_division;
        private string nom_proyecto;
        private string dir_proyecto;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;

        public ProyectoBE() {
        }

        public ProyectoBE(int id_proyecto, string nom_proyecto) {
            this.id_proyecto = id_proyecto;
            this.nom_proyecto = nom_proyecto;
        }

        public ProyectoBE(int id_proyecto, int id_cliente, int id_division, string nom_proyecto, string dir_proyecto, DateTime fecha_inicio, DateTime fecha_fin)
        {
            this.id_proyecto = id_proyecto;
            this.id_cliente = id_cliente;
            this.id_division = id_division;
            this.nom_proyecto = nom_proyecto;
            this.dir_proyecto = dir_proyecto;
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin = fecha_fin;
        }

        public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_division { get => id_division; set => id_division = value; }
        public string Nom_proyecto { get => nom_proyecto; set => nom_proyecto = value; }
        public string Dir_proyecto { get => dir_proyecto; set => dir_proyecto = value; }
        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public DateTime Fecha_fin { get => fecha_fin; set => fecha_fin = value; }
    }
}
