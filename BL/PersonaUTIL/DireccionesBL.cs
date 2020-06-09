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

        public Boolean DireccionNew(DireccionBE dirbe) {
            return dir.DireccionNew(dirbe);
        }

        public DataTable ListarCiudadesPorIdRegion(int idRegion) {
            return dir.ListarCiudadesPorIdRegion(idRegion);
        }

        public DataTable ListarDistritosPorIdCiudad(int idCiudad) {
            return dir.ListarDistritosPorIdCiudad(idCiudad);
        }

        public DataTable ListarRegionesPorIdPais(int idPais) {
            return dir.ListarRegionesPorIdPais(idPais);
        }

        public DataTable ListarDireccionesFull() {
            return dir.ListarDireccionesFull();
        }
        public DataTable ListarDireccionesFullPorId(int idPersona) {
            return dir.ListarDireccionesFullPorId(idPersona);
        }
    }
}
