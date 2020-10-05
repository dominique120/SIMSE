using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE._EFE {
    public class TelefonosTiposEFE {
        private string tipo_telefono;
        private int id;

        public TelefonosTiposEFE(string tipo_telefono, int id) {
            this.Tipo_telefono = tipo_telefono;
            this.Id = id;
        }

        public string Tipo_telefono { get => tipo_telefono; set => tipo_telefono = value; }
        public int Id { get => id; set => id = value; }
    }
}
