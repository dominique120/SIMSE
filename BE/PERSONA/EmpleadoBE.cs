using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.PERSONA
{
    public class EmpleadoBE
    {
        private int id_persona;
        private short puesto_empleado;
        private string doc_oficial;
        private string ruc_empleado;
        private DateTime fecha_nacimiento;
        private DateTime fecha_inicio;
        private string primer_nom;
        private string segundo_nom;
        private string primer_ape;
        private string segundo_ape;

        public EmpleadoBE(int id_persona, short puesto_empleado, string doc_oficial, string ruc_empleado, DateTime fecha_nacimiento, DateTime fecha_inicio, string primer_nom, string segundo_nom, string primer_ape, string segundo_ape) {
            this.id_persona = id_persona;
            this.puesto_empleado = puesto_empleado;
            this.doc_oficial = doc_oficial;
            this.ruc_empleado = ruc_empleado;
            this.fecha_nacimiento = fecha_nacimiento;
            this.fecha_inicio = fecha_inicio;
            this.primer_nom = primer_nom;
            this.segundo_nom = segundo_nom;
            this.primer_ape = primer_ape;
            this.segundo_ape = segundo_ape;
        }

        public int Id_persona { get => id_persona; set => id_persona = value; }
        public short Puesto_empleado { get => puesto_empleado; set => puesto_empleado = value; }
        public string Doc_oficial { get => doc_oficial; set => doc_oficial = value; }
        public string Ruc_empleado { get => ruc_empleado; set => ruc_empleado = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public string Primer_nom { get => primer_nom; set => primer_nom = value; }
        public string Segundo_nom { get => segundo_nom; set => segundo_nom = value; }
        public string Primer_ape { get => primer_ape; set => primer_ape = value; }
        public string Segundo_ape { get => segundo_ape; set => segundo_ape = value; }
    }
}
