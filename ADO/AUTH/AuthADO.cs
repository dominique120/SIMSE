using BE.AUTH;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.AUTH {
    public class AuthADO {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        bool success;

        public AuthBE CredentialSelect(string username) {
            AuthBE authBE = new AuthBE();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.CredentialSelect";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario", username);

                con.Open();
                SqlDataReader dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true) {
                    dtr.Read();
                    authBE.Id_usuario = int.Parse(dtr["id_usuario"].ToString());
                    authBE.Empleado = int.Parse(dtr["empleado"].ToString());
                    authBE.Password = dtr["password"].ToString();
                    authBE.Usuario = dtr["usuario"].ToString();
                    authBE.Salt = dtr["salt"].ToString();
                    authBE.Active = bool.Parse(dtr["active"].ToString());
                } else {
                    throw new Exception("El usuario no Existe");
                }
                dtr.Close();

            } catch (Exception ex) {
                throw new Exception("El usuario no existe: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
                cmd.Parameters.Clear();
            }
            return authBE;
        }

        public Boolean EliminarCredencial(string usuario) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.EliminarCredencial";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario", usuario);

                con.Open();
                cmd.ExecuteNonQuery();

                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
                cmd.Parameters.Clear();
            }
            return success;
        }

        public Boolean CredentialNew(AuthBE authBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.CredentialNew";

            //string HashedPasswordString = Encoding.UTF8.GetString(authBE.HashedPassword);
            string HashedPasswordString = Convert.ToBase64String(authBE.HashedPassword);
            
            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario", authBE.Usuario);
                cmd.Parameters.AddWithValue("@password", HashedPasswordString);
                cmd.Parameters.AddWithValue("@salt", authBE.Salt);
                cmd.Parameters.AddWithValue("@active", authBE.Active);
                cmd.Parameters.AddWithValue("@empleado", authBE.Empleado);

                con.Open();
                cmd.ExecuteNonQuery();

                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
                cmd.Parameters.Clear();
            }
            return success;
        }


        public Boolean CredentialUpdate(AuthBE authBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.CredentialUpdate";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_usuario", authBE.Id_usuario);
                cmd.Parameters.AddWithValue("@usuario", authBE.Usuario);
                cmd.Parameters.AddWithValue("@password", authBE.Password);
                cmd.Parameters.AddWithValue("@salt", authBE.Salt);
                cmd.Parameters.AddWithValue("@active", authBE.Active);
                cmd.Parameters.AddWithValue("@empleado", authBE.Empleado);

                con.Open();
                cmd.ExecuteNonQuery();

                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
                cmd.Parameters.Clear();
            }
            return success;
        }

        public Boolean CredentialDeactivate(AuthBE authBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.crud_CREDENTIALDeactivate";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_usuario", authBE.Id_usuario);

                con.Open();
                cmd.ExecuteNonQuery();

                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
                cmd.Parameters.Clear();
            }
            return success;
        }

        public Boolean CredentialActivate(AuthBE authBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.crud_CREDENTIALActivate";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_usuario", authBE.Id_usuario);

                con.Open();
                cmd.ExecuteNonQuery();

                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
                cmd.Parameters.Clear();
            }
            return success;
        }

        public DataTable ListarCredenciales() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarCredenciales";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Credenciales");
            } catch (Exception ex) {
                throw new Exception("Error mostrando las credenciales: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
            return dts.Tables["Credenciales"];
        }

        public bool IsAvailable() {
            con.ConnectionString = conection.GetCon();
            try {
                con.Open();
                con.Close();
            } catch (SqlException) {
                return false;
            }
            return true;
        }
    }
}
