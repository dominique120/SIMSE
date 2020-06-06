using ADO;
using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Persona
{
    public class EmpleadoBL {
        EmpleadoADO empado = new EmpleadoADO();

        public Boolean NuevoEmpleado(EmpleadoBE empbe) {
            return empado.NuevoEmpleado(empbe);
        }
        public DataTable ListarEmpleadosFull() {
            return empado.ListarEmpleadosFull();
        }

        public bool RevisarEstado(int idEmpleado) {
            return empado.RevisarEstado(idEmpleado);
        }

        public Boolean UpdateEstado(int idEmpleado, bool estado) {
            return empado.UpdateEstado(idEmpleado, estado);
        }

        public Boolean ModificarEmpleado(EmpleadoBE empbe) {
            return empado.ModificarEmpleado(empbe);
        }

        public EmpleadoBE ListarEmpleadosPorId(int idEmpleado) {
            return empado.ListarEmpleadosPorId(idEmpleado);
        }
    }
}
