using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.PERSONA {
    public class EmailBE {
        private int id_email;
        private short tipo_email;
        private int id_persona;
        private string direccion_email;

        public EmailBE() {
        }

        public EmailBE( short tipo_email, int id_persona, string direccion_email) {
            this.tipo_email = tipo_email;
            this.id_persona = id_persona;
            this.direccion_email = direccion_email;
        }

        public int Id_email { get => id_email; set => id_email = value; }
        public short Tipo_email { get => tipo_email; set => tipo_email = value; }
        public int Id_persona { get => id_persona; set => id_persona = value; }
        public string Direccion_email { get => direccion_email; set => direccion_email = value; }
    }
}
