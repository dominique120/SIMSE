using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.PERSONA {
    public class DireccionBE {
        private int id_direccion;
        private byte tipo_direccion;
        private int id_persona;
        private short dir_pais;
        private int dir_provincia;
        private int dir_ciudad;
        private int dir_distrito;
        private string dir_linea_1;
        private string dir_linea_2;
        private string dir_codigo_postal;

        public DireccionBE(byte tipo_direccion, int id_persona, short dir_pais, int dir_provincia, int dir_ciudad, int dir_distrito, string dir_linea_1, string dir_linea_2, string dir_codigo_postal) {
            this.tipo_direccion = tipo_direccion;
            this.id_persona = id_persona;
            this.dir_pais = dir_pais;
            this.dir_provincia = dir_provincia;
            this.dir_ciudad = dir_ciudad;
            this.dir_distrito = dir_distrito;
            this.dir_linea_1 = dir_linea_1;
            this.dir_linea_2 = dir_linea_2;
            this.dir_codigo_postal = dir_codigo_postal;
        }

        public int Id_direccion { get => id_direccion; set => id_direccion = value; }
        public byte Tipo_direccion { get => tipo_direccion; set => tipo_direccion = value; }
        public int Id_persona { get => id_persona; set => id_persona = value; }
        public short Dir_pais { get => dir_pais; set => dir_pais = value; }
        public int Dir_provincia { get => dir_provincia; set => dir_provincia = value; }
        public int Dir_ciudad { get => dir_ciudad; set => dir_ciudad = value; }
        public int Dir_distrito { get => dir_distrito; set => dir_distrito = value; }
        public string Dir_linea_1 { get => dir_linea_1; set => dir_linea_1 = value; }
        public string Dir_linea_2 { get => dir_linea_2; set => dir_linea_2 = value; }
        public string Dir_codigo_postal { get => dir_codigo_postal; set => dir_codigo_postal = value; }
    }
}
