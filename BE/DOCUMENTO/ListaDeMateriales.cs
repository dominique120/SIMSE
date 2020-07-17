using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.DOCUMENTO {
    public class ListaDeMaterialesBE {
        private int id_documento;
        private int proyecto;
        private int pedido_por;
        private DateTime fecha_pedida;
        private DateTime fecha_aprobada;
        private bool aprobado;
        private int aprobado_por;
        private int ingresado_por;
        private DataTable detalleDeListaMateriales;

        public ListaDeMaterialesBE() {
        }

        public ListaDeMaterialesBE(int id_documento, int proyecto, int pedido_por, DateTime fecha_pedida, DateTime fecha_aprobada, bool aprobado, int aprobado_por, int ingresado_por, DataTable detalleDeListaMateriales) {
            this.id_documento = id_documento;
            this.proyecto = proyecto;
            this.pedido_por = pedido_por;
            this.fecha_pedida = fecha_pedida;
            this.fecha_aprobada = fecha_aprobada;
            this.aprobado = aprobado;
            this.aprobado_por = aprobado_por;
            this.ingresado_por = ingresado_por;
            this.detalleDeListaMateriales = detalleDeListaMateriales;
        }

        public int Id_documento { get => id_documento; set => id_documento = value; }
        public int Proyecto { get => proyecto; set => proyecto = value; }
        public int Pedido_por { get => pedido_por; set => pedido_por = value; }
        public DateTime Fecha_pedida { get => fecha_pedida; set => fecha_pedida = value; }
        public DateTime Fecha_aprobada { get => fecha_aprobada; set => fecha_aprobada = value; }
        public bool Aprobado { get => aprobado; set => aprobado = value; }
        public int Aprobado_por { get => aprobado_por; set => aprobado_por = value; }
        public int Ingresado_por { get => ingresado_por; set => ingresado_por = value; }
        public DataTable DetalleDeListaMateriales { get => detalleDeListaMateriales; set => detalleDeListaMateriales = value; }
    }
}
