using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.PERSONA {
    public class ClienteBE {
        private int id_persona;
        private int marketing;
        private string nom_cliente;
        private string doc_oficial;

        public ClienteBE() {
        }

        public ClienteBE(int id_persona, int marketing, string nom_cliente, string doc_oficial) {
            this.id_persona = id_persona;
            this.marketing = marketing;
            this.nom_cliente = nom_cliente;
            this.doc_oficial = doc_oficial;
        }

        public int Id_persona { get => id_persona; set => id_persona = value; }
        public int Marketing { get => marketing; set => marketing = value; }
        public string Nom_cliente { get => nom_cliente; set => nom_cliente = value; }
        public string Doc_oficial { get => doc_oficial; set => doc_oficial = value; }
    }
}
