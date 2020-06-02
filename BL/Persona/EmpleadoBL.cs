using ADO;
using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Persona
{
    class EmpleadoBL
    {
        EmpleadoADO empado = new EmpleadoADO();

        public Boolean NuevoEmpleado(EmpleadoBE empbe)
        {
            return empado.NuevoEmpleado(empbe);
        }
    }
}
