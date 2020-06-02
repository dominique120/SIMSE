using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.PERSONA {
    class SalarioBE {
        private int id_persona;
        private int id_salario;
        private float monto;
        private byte frequencia_de_pago_dias;
        private DateTime fecha_modificada;

        public SalarioBE(int id_persona, int id_salario, float monto, byte frequencia_de_pago_dias, DateTime fecha_modificada) {
            this.id_persona = id_persona;
            this.id_salario = id_salario;
            this.monto = monto;
            this.frequencia_de_pago_dias = frequencia_de_pago_dias;
            this.fecha_modificada = fecha_modificada;
        }

        public int Id_persona { get => id_persona; set => id_persona = value; }
        public int Id_salario { get => id_salario; set => id_salario = value; }
        public float Monto { get => monto; set => monto = value; }
        public byte Frequencia_de_pago_dias { get => frequencia_de_pago_dias; set => frequencia_de_pago_dias = value; }
        public DateTime Fecha_modificada { get => fecha_modificada; set => fecha_modificada = value; }
    }
}
