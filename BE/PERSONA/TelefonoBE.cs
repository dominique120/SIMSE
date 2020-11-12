using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.PERSONA {
    public class TelefonoBE {
        private int id_telefono;
        private short tipo_telefono;
        private int id_persona;
        private string codigo_pais;
        private string campo_1;
        private string campo_2;
        private string campo_3;
        private string ext;

        public TelefonoBE() {
        }

        public TelefonoBE( short tipo_telefono, int id_persona, string codigo_pais, string campo_1, string campo_2, string campo_3, string ext) {
            
            this.tipo_telefono = tipo_telefono;
            this.id_persona = id_persona;
            this.codigo_pais = codigo_pais;
            this.campo_1 = campo_1;
            this.campo_2 = campo_2;
            this.campo_3 = campo_3;
            this.ext = ext;
        }

        public int Id_telefono { get => id_telefono; set => id_telefono = value; }
        public short Tipo_telefono { get => tipo_telefono; set => tipo_telefono = value; }
        public int Id_persona { get => id_persona; set => id_persona = value; }
        public string Codigo_pais { get => codigo_pais; set => codigo_pais = value; }
        public string Campo_1 { get => campo_1; set => campo_1 = value; }
        public string Campo_2 { get => campo_2; set => campo_2 = value; }
        public string Campo_3 { get => campo_3; set => campo_3 = value; }
        public string Ext { get => ext; set => ext = value; }
    }
}
