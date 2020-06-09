using ADO.PersonaUTIL;
using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.UTIL {
    public class TelefonosBL {
        TelefonoADO tel = new TelefonoADO();

        public DataTable ListarTelefonos() {
            return tel.ListarTelefonos();
        }

        public DataTable ListarTelefonosTipos() {
            return tel.ListarTelefonosTipos();
        }

        TelefonoADO telado = new TelefonoADO();
        public Boolean TelefonoNew(TelefonoBE telbe) {
            return telado.TelefonoNew(telbe);
        }
        public DataTable ListarTelefonosFull()
        {
            return tel.ListarTelefonosFull();
        }
        public DataTable ListarTelefonosFullPorId(int idPersona)
        {
            return tel.ListarTelefonosFullPorId(idPersona);
        }
    }
}
