using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.MARKETING {
    public class FichaMarketingBE {

        private int id_ficha_marketing;
        private int id_persona_fuente;
        private short forma_contacto_inical;
        private short primer_interes;
        private DateTime fecha_primer_contacto;
        private DateTime fecha_ultimo_contacto;

        public FichaMarketingBE(int id_ficha_marketing, int id_persona_fuente, short forma_contacto_inical, short primer_interes, DateTime fecha_primer_contacto, DateTime fecha_ultimo_contacto) {
            this.id_ficha_marketing = id_ficha_marketing;
            this.id_persona_fuente = id_persona_fuente;
            this.forma_contacto_inical = forma_contacto_inical;
            this.primer_interes = primer_interes;
            this.fecha_primer_contacto = fecha_primer_contacto;
            this.fecha_ultimo_contacto = fecha_ultimo_contacto;
        }

        public FichaMarketingBE( int id_persona_fuente, short forma_contacto_inical, short primer_interes, DateTime fecha_primer_contacto, DateTime fecha_ultimo_contacto) {
            this.id_persona_fuente = id_persona_fuente;
            this.forma_contacto_inical = forma_contacto_inical;
            this.primer_interes = primer_interes;
            this.fecha_primer_contacto = fecha_primer_contacto;
            this.fecha_ultimo_contacto = fecha_ultimo_contacto;
        }

        public int Id_ficha_marketing { get => id_ficha_marketing; set => id_ficha_marketing = value; }
        public int Id_persona_fuente { get => id_persona_fuente; set => id_persona_fuente = value; }
        public short Forma_contacto_inical { get => forma_contacto_inical; set => forma_contacto_inical = value; }
        public short Primer_interes { get => primer_interes; set => primer_interes = value; }
        public DateTime Fecha_primer_contacto { get => fecha_primer_contacto; set => fecha_primer_contacto = value; }
        public DateTime Fecha_ultimo_contacto { get => fecha_ultimo_contacto; set => fecha_ultimo_contacto = value; }
    }
}
