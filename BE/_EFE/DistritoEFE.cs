using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE._EFE {
    public class DistritoEFE {
        private int id_ciudad;
        private int id_distrito;
        private string nom_distrito;

        public DistritoEFE(int id_ciudad, int id_distrito, string nom_distrito) {
            this.Id_ciudad = id_ciudad;
            this.Id_distrito = id_distrito;
            this.Nom_distrito = nom_distrito;
        }

        public int Id_ciudad { get => id_ciudad; set => id_ciudad = value; }
        public int Id_distrito { get => id_distrito; set => id_distrito = value; }
        public string Nom_distrito { get => nom_distrito; set => nom_distrito = value; }
    }
}
