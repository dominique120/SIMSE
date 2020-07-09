﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.DOCUMENTO;
namespace BL.Documento {

    public class PlanosBL {

        PlanosADO pla = new PlanosADO();

        public DataTable ListarPlanosFull() {
            return pla.ListarPlanosFull();
        }

        public DataTable ListarPlanosPorProyectoTipo(int id_proyecto, int id_tipo) {
            return pla.ListarPlanosPorProyectoTipo(id_proyecto, id_tipo);
        }

        public DataTable ListarTiposDePlano() {
            return pla.ListarTiposDePlano();
        }
    }
}