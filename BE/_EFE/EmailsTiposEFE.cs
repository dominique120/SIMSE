using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE._EFE {
    public class EmailsTiposEFE {
        private string tipo_email;
        private int id;

        public EmailsTiposEFE(string tipo_email, int id) {
            this.Tipo_Email = tipo_email;
            this.Id = id;
        }

        public string Tipo_Email { get => tipo_email; set => tipo_email = value; }
        public int Id { get => id; set => id = value; }
    }
}
