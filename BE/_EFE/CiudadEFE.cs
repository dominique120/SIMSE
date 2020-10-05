using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE._EFE {
    public class CiudadEFE {
        private int id_ciudad;
        private int id_region;
        private string nom_ciudad;
        public CiudadEFE(int id_ciudad, int id_region, string nom_ciudad) {
            this.Id_ciudad = id_ciudad;
            this.Id_region = id_region;
            this.Nom_ciudad = nom_ciudad;
        }

        public int Id_ciudad { get => id_ciudad; set => id_ciudad = value; }
        public int Id_region { get => id_region; set => id_region = value; }
        public string Nom_ciudad { get => nom_ciudad; set => nom_ciudad = value; }
    }
}
