using ADO;
using BE.PROYECTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL.Proyecto
{
    public class ProyectoBL
    {
        ProyectoADO proyado = new ProyectoADO();

        public Boolean NuevoProyecto(ProyectoBE proybe)
        {
            return proyado.NuevoProyecto(proybe);
        }
    }
}
