using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.PersonaUTIL {
    public class EmailADO {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable ListarEmailsTipos() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarEmailsTipos";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "EmailsTipos");
            } catch (Exception ex) {
                throw new Exception("Error mostrando los tipos de email: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
            return dts.Tables["EmailsTipos"];
        }


        Boolean success = false;
        public Boolean EmailNew(EmailBE emBe) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.EmailNew";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_persona", emBe.Id_persona);
                cmd.Parameters.AddWithValue("@tipo_email", emBe.Tipo_email);
                cmd.Parameters.AddWithValue("@direccion_email", emBe.Direccion_email);

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
        public DataTable ListarEmailsFull()
        {
            DataSet dts = new DataSet();
            try
            {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarEmailsFull";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Emails");
            }
            catch (Exception ex)
            {
                throw new Exception("Error mostrando los emails: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
            return dts.Tables["Emails"];
        }

        public DataTable ListarEmailsFullPorId(int idPersona)
        {
            DataSet dts = new DataSet();
            try
            {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarEmailsFullPorId";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_persona", idPersona);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Emails");
            }
            catch (Exception ex)
            {
                throw new Exception("Error mostrando los email: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
            return dts.Tables["Emails"];
        }

        public EmailBE SelectEmail(int id_email) {
            DataSet dts = new DataSet();
            EmailBE emBE = new EmailBE();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.SelectEmail";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_email", id_email);

                con.Open();
                SqlDataReader dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true) {
                    dtr.Read();

                    emBE.Direccion_email = dtr["direccion_email"].ToString();
                    emBE.Id_email = int.Parse(dtr["id_email"].ToString());
                    emBE.Id_persona = int.Parse(dtr["id_persona"].ToString());
                    emBE.Tipo_email = short.Parse(dtr["tipo_email"].ToString());

                } else {
                    throw new Exception("Error al buscar el email.");
                }
                dtr.Close();
            } catch (Exception ex) {
                throw new Exception("Error mostrando los emails: " + ex.Message);
            } finally {
                con.Close();
            }
            return emBE;
        }

        public bool ModificarEmail(EmailBE emailBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.ModificarEmail";

            try {
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@tipo_email", emailBE.Tipo_email);
                cmd.Parameters.AddWithValue("@id_email", emailBE.Id_email);
                cmd.Parameters.AddWithValue("@id_persona", emailBE.Id_persona);
                cmd.Parameters.AddWithValue("@direccion_email", emailBE.Direccion_email);

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

        public Boolean EliminarEmail(int idEmail) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.EliminarEmail";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_email", idEmail);

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
    }
}
