﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.DOCUMENTO;

namespace BL.Documento {
    public class EntregaFinalBL {
        EntregaFinalADO entregaFinal = new EntregaFinalADO();
        public DataTable ListarEntregasFinalesFechas(DateTime fecha_inicio, DateTime fecha_fin) {
            return entregaFinal.ListarEntregasFinalesFechas(fecha_inicio, fecha_fin);
        }

        public DataTable ListarEntregaFinalFull() {
            return entregaFinal.ListarEntregaFinalFull();
        }

    }
}