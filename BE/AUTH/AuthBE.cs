using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.AUTH {
    public class AuthBE {
        private int id_usuario;
        private string usuario;
        private string password;
        private string salt;
        private bool active;
        private int empleado;
        private byte[] hashedPassword;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string Salt { get => salt; set => salt = value; }
        public bool Active { get => active; set => active = value; }
        public int Empleado { get => empleado; set => empleado = value; }
        public byte[] HashedPassword { get => hashedPassword; set => hashedPassword = value; }

        public AuthBE(int id_usuario, string usuario, string password, string salt, bool active, int empleado) {
            this.id_usuario = id_usuario;
            this.usuario = usuario;
            this.password = password;
            this.salt = salt;
            this.active = active;
            this.empleado = empleado;
        }

        public AuthBE(string usuario, string password, string salt, bool active, int empleado) {
            this.usuario = usuario;
            this.password = password;
            this.salt = salt;
            this.active = active;
            this.empleado = empleado;
        }

        public AuthBE() {

        }

        public AuthBE(string usuario, string password) {
            this.usuario = usuario;
            this.password = password;
        }

        public AuthBE(string usuario, string password, int empleado, bool active) {
            this.usuario = usuario;
            this.password = password;
            this.empleado = empleado;
            this.active = active;
        }
    }
}
