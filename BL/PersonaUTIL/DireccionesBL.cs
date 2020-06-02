using ADO.PersonaUTIL.Direcciones;
using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BL.UTIL {
    public class DireccionesBL {
        DireccionADO dir = new DireccionADO();

        public DataTable ListarPaises() {
            return dir.ListarPaises();
        }

        public DataTable ListarCiudades() {
            return dir.ListarCiudades();
        }

        public DataTable ListarDistritos() {
            return dir.ListarDistritos();
        }

        public DataTable ListarRegiones() {
            return dir.ListarRegiones();
        }

        public DataTable ListarDireccionesTipos() {
            return dir.ListarDireccionesTipos();
        }

        DireccionADO dirado = new DireccionADO();
        public Boolean DireccionNew(DireccionBE dirbe) {
            return dirado.DireccionNew(dirbe);
        }
    }
}
