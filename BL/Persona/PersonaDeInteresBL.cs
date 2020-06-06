using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO;
using BE.PERSONA;
using BE;
using System.Data;

namespace BL.Persona {
    public class PersonaDeInteresBL {
        PersonaInteresADO perintado = new PersonaInteresADO();
        public Boolean PersonaDeInteresNew(PersonaDeInteresBE PerIntBE) {
            return perintado.PersonaDeInteresNew(PerIntBE);
        }


        PersonaInteresADO puest = new PersonaInteresADO();

        public DataTable ListarPuestos() {
            return puest.ListarPuestos();
        }

        PersonaInteresADO proy = new PersonaInteresADO();

        public DataTable ListarProyecto() {
            return puest.ListarProyecto();
        }


        public Boolean InsertarPersonaInt(PersonaDeInteresBE objPersonaDeIntersBE) {
            return perintado.PersonaDeInteresNew(objPersonaDeIntersBE);
        }

        public PersonaDeInteresBE ListarPersonasDeInteresPorId(int idPersonaInter) {
            return perintado.ListarPersonasDeInteresPorId(idPersonaInter);
        }

        public DataTable ListarPersonasDeInteres() {
            return perintado.ListarPersonasDeInteres();
        }
        public Boolean ModificarPersonaInteres(PersonaDeInteresBE perinteBE) {
            return perintado.ModificarPersonaInteres(perinteBE);
        }
        public Boolean EliminarPersonaDeInteres(int idPersona) {
            return perintado.EliminarPersonaDeInteres(idPersona);
        }
    }
}
