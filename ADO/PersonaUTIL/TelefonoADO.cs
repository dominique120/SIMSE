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
                adapter.Fill(dts, "Telefonos");
            } catch (Exception ex) {
                throw new Exception("Error mostrando los telefonos: " + ex.Message);
            }
            return dts.Tables["Telefonos"];
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
                throw new Exception("Error mostrando los tipos de telefonos: " + ex.Message);
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
    }
}
