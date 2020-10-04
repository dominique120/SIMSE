using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE._EFE {
    public class PuestoEFE {
        private int id;
        private string desc;

        public PuestoEFE(int id, string desc) {
            this.id = id;
            this.desc = desc;
        }

        public int Id { get => id; set => id = value; }
        public string Desc { get => desc; set => desc = value; }
    }
}
