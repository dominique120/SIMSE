using ADO;
using BE.PROYECTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL.Proyecto
{
    public class ProyectoBL {
        ProyectoADO proyado = new ProyectoADO();

        public Boolean NuevoProyecto(ProyectoBE proybe) {
            return proyado.NuevoProyecto(proybe);
        }

        public DataTable ListarDivisiones() {
            return proyado.ListarDivisiones();
        }
        public ProyectoBE ListarPersonasDeInteresPorId(int idProyecto) {
            return proyado.ListarPersonasDeInteresPorId(idProyecto);
        }

        public Boolean ModificarProyecto(ProyectoBE proyBE) {
            return proyado.ModificarProyecto(proyBE);
        }
        public DataTable ListarProyectos() {
            return proyado.ListarProyectos();
        }
    }
}
