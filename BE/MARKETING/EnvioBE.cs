using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.MARKETING {
    public class EnvioBE {
        private int id_envio;
        private int id_recividor;
        private int id_ficha_marketing;
        private int id_enviador;
        private short presentacion_enviada;
        private DateTime fecha;

        public EnvioBE(int id_envio, int id_recividor, int id_ficha_marketing, int id_enviador, short presentacion_enviada, DateTime fecha) {
            this.id_envio = id_envio;
            this.id_recividor = id_recividor;
            this.id_ficha_marketing = id_ficha_marketing;
            this.id_enviador = id_enviador;
            this.presentacion_enviada = presentacion_enviada;
            this.fecha = fecha;
        }

        public int Id_envio { get => id_envio; set => id_envio = value; }
        public int Id_recividor { get => id_recividor; set => id_recividor = value; }
        public int Id_ficha_marketing { get => id_ficha_marketing; set => id_ficha_marketing = value; }
        public int Id_enviador { get => id_enviador; set => id_enviador = value; }
        public short Presentacion_enviada { get => presentacion_enviada; set => presentacion_enviada = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
