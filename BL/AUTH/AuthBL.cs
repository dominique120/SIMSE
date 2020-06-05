using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BE.AUTH;
using ADO.AUTH;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;

namespace BL.AUTH {
    public class AuthBL {
        AuthADO authado = new AuthADO();

        public AuthBE CredentialSelect(string username) {
            return authado.CredentialSelect(username);
        }

        public Boolean CredentialUpdate(AuthBE authBE) {
            return authado.CredentialUpdate(authBE);
        }

        public Boolean CredentialDeactivate(AuthBE authBE) {
            return authado.CredentialDeactivate(authBE);
        }

        public Boolean CredentialActivate(AuthBE authBE) {
            return authado.CredentialActivate(authBE);
        }

        public bool Authenticate(AuthBE authBE) {
            string EnteredPwd = authBE.Password;
            string EnteredUsr = authBE.Usuario;

            AuthBE SelectedCredentials = new AuthBE();
            SelectedCredentials = authado.CredentialSelect(EnteredUsr);

            if (SelectedCredentials.Usuario.Length == 0) {
                return false;
            }

            if (SelectedCredentials.Active == false) {
                return false;
            }

            AuthBE GeneratedAuthBE = new AuthBE();
            GeneratedAuthBE.Salt = SelectedCredentials.Salt;
            GeneratedAuthBE.Password = EnteredPwd;
            GeneratedAuthBE.HashedPassword = GenerateSaltedHash(Encoding.UTF32.GetBytes(GeneratedAuthBE.Password), Convert.FromBase64String(SelectedCredentials.Salt));
            string HashedPasswordString = Convert.ToBase64String(GeneratedAuthBE.HashedPassword);


            bool comparison = string.Equals(HashedPasswordString, SelectedCredentials.Password.Trim());

            if (comparison == true) {
                return true;
            } else {
                return false;
            }

        }

        public Boolean CredentialNew(AuthBE authBE) {
            AuthBE EnteredAuthBE = new AuthBE(authBE.Usuario, authBE.Password, authBE.Empleado, authBE.Active);

            AuthBE GeneratedAuthBE = new AuthBE();

            GeneratedAuthBE.Active = EnteredAuthBE.Active;
            GeneratedAuthBE.Empleado = EnteredAuthBE.Empleado;
            GeneratedAuthBE.Usuario = EnteredAuthBE.Usuario;
            GeneratedAuthBE.Password = EnteredAuthBE.Password;

            GeneratedAuthBE.Salt = CreateSalt(32);
            GeneratedAuthBE.HashedPassword = GenerateSaltedHash(Encoding.UTF32.GetBytes(GeneratedAuthBE.Password), Convert.FromBase64String(GeneratedAuthBE.Salt));
            
            return authado.CredentialNew(GeneratedAuthBE);
        }

        private static string CreateSalt(int size) {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        private static byte[] GenerateSaltedHash(byte[] plainText, byte[] salt) {
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes =
              new byte[plainText.Length + salt.Length];

            for (int i = 0; i < plainText.Length; i++) {
                plainTextWithSaltBytes[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++) {
                plainTextWithSaltBytes[plainText.Length + i] = salt[i];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes);
        }

        public static bool CompareByteArrays(byte[] array1, byte[] array2) {
            if (array1.Length != array2.Length) {
                return false;
            }

            for (int i = 0; i < array1.Length; i++) {
                if (array1[i] != array2[i]) {
                    return false;
                }
            }

            return true;
        }

    }

}

