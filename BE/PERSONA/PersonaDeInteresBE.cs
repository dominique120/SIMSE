using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE {
    public class PersonaDeInteresBE {
        private int id_persona;
        private int id_directorio;
        private int id_proyecto;
        private short puesto;
        private string nom_persona;

        public PersonaDeInteresBE(int id_persona, int id_directorio, int id_proyecto, short puesto, string nom_persona) {
            this.id_persona = id_persona;
            this.id_directorio = id_directorio;
            this.id_proyecto = id_proyecto;
            this.puesto = puesto;
            this.nom_persona = nom_persona;
        }

        public int Id_persona { get => id_persona; set => id_persona = value; }
        public int Id_directorio { get => id_directorio; set => id_directorio = value; }
        public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
        public short Puesto { get => puesto; set => puesto = value; }
        public string Nom_persona { get => nom_persona; set => nom_persona = value; }
    }
}
