using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE._EFE {
    public class RegionEFE {
        private int id_region;
        private int id_pais;
        private string nom_region;
        public RegionEFE(int id_region, int id_pais, string nom_region) {
            this.Id_region = id_region;
            this.Id_pais = id_pais;
            this.Nom_region = nom_region;
        }
        public int Id_pais { get => id_pais; set => id_pais = value; }
        public int Id_region { get => id_region; set => id_region = value; }
        public string Nom_region { get => nom_region; set => nom_region = value; }
    }
}
