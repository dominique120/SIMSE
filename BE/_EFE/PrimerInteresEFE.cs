using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE._EFE {
    public class PrimerInteresEFE {
        private int id;
        private string desc_primer_interes;

        public PrimerInteresEFE(int id, string nombre) {
            this.Id = id;
            this.Nombre = nombre;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => desc_primer_interes; set => desc_primer_interes = value; }
    }
}
