using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.PersonaUTIL {
    public class TelefonoADO {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable ListarTelefonos() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarTelefonos";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Teléfonos");
            } catch (Exception ex) {
                throw new Exception("Error mostrando los teléfonos: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
                cmd.Parameters.Clear();
            }
            return dts.Tables["Teléfonos"];
        }

        public DataTable ListarTelefonosTipos() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarTelefonosTipos";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "TelefonosTipos");
            } catch (Exception ex) {
                throw new Exception("Error mostrando los tipos de teléfonos: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
                cmd.Parameters.Clear();
            }
            return dts.Tables["TelefonosTipos"];
        }


        Boolean success = false;
        public Boolean TelefonoNew(TelefonoBE telBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.TelefonoNew";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_persona", telBE.Id_persona);
                cmd.Parameters.AddWithValue("@codigo_pais", telBE.Codigo_pais);
                cmd.Parameters.AddWithValue("@campo_1", telBE.Campo_1);
                cmd.Parameters.AddWithValue("@campo_2", telBE.Campo_2);
                cmd.Parameters.AddWithValue("@campo_3", telBE.Campo_3);
                cmd.Parameters.AddWithValue("@ext", telBE.Ext);
                cmd.Parameters.AddWithValue("@tipo_telefono", telBE.Tipo_telefono);

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
        public DataTable ListarTelefonosFull()
        {
            DataSet dts = new DataSet();
            try
            {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.LestarTelefonosFull";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Teléfonos");
            }
            catch (Exception ex)
            {
                throw new Exception("Error mostrando los teléfonos: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                    cmd.Parameters.Clear();
                }
            }
            return dts.Tables["Teléfonos"];
        }

        public DataTable ListarTelefonosFullPorId(int idPersona)
        {
            DataSet dts = new DataSet();
            try
            {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.LestarTelefonosFullPorId";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_persona", idPersona);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Teléfonos");
            }
            catch (Exception ex)
            {
                throw new Exception("Error mostrando los emails: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();

                }
                cmd.Parameters.Clear();
            }
            return dts.Tables["Teléfonos"];
        }

        public Boolean EliminarTelefono(int idTelefono) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.EliminarTelefono";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_telefono", idTelefono);

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

        public Boolean ModificarTelefono(TelefonoBE telBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.ModificarTelefono";

            try {
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id_telefono", telBE.Id_telefono);
                cmd.Parameters.AddWithValue("@tipo_telefono", telBE.Tipo_telefono);
                cmd.Parameters.AddWithValue("@codigo_pais", telBE.Codigo_pais);
                cmd.Parameters.AddWithValue("@campo_1", telBE.Campo_1);
                cmd.Parameters.AddWithValue("@campo_2", telBE.Campo_2);
                cmd.Parameters.AddWithValue("@campo_3", telBE.Campo_3);
                cmd.Parameters.AddWithValue("@ext", telBE.Ext);

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

        public TelefonoBE SelectTelefono(int id_telefono) {
            DataSet dts = new DataSet();
            TelefonoBE telBE = new TelefonoBE();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.SelectTelefono";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_telefono", id_telefono);

                con.Open();
                SqlDataReader dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true) {
                    dtr.Read();

                    telBE.Campo_1 = dtr["campo_1"].ToString();
                    telBE.Campo_2 = dtr["campo_2"].ToString();
                    telBE.Campo_3 = dtr["campo_3"].ToString();
                    telBE.Codigo_pais = dtr["codigo_pais"].ToString();
                    telBE.Tipo_telefono = short.Parse(dtr["tipo_telefono"].ToString());
                    telBE.Id_telefono = int.Parse(dtr["id_telefono"].ToString());
                    telBE.Id_persona = int.Parse(dtr["id_persona"].ToString());
                    telBE.Ext = dtr["ext"].ToString();

                } else {
                    throw new Exception("Error al buscar el teléfono.");
                }
                dtr.Close();
            } catch (Exception ex) {
                throw new Exception("Error mostrando los teléfonos: " + ex.Message);
            } finally {
                con.Close();
            }
            cmd.Parameters.Clear();
            return telBE;
        }
    }
}
