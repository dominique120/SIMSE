using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BE;

namespace ADO {
    public class PersonaInteresADO {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        Boolean success = false;

        public Boolean PersonaDeInteresNew(PersonaDeInteresBE PerIntBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.PersonaDeInteresNew";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_persona", PerIntBE.Id_persona);
                cmd.Parameters.AddWithValue("@id_directorio", PerIntBE.Id_directorio);
                cmd.Parameters.AddWithValue("@id_proyecto", PerIntBE.Id_proyecto);
                cmd.Parameters.AddWithValue("@puesto", PerIntBE.Puesto);
                cmd.Parameters.AddWithValue("@nom_persona", PerIntBE.Nom_persona);

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
        public DataTable ListarPuestos() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarPuestos";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Puestos");
            } catch (Exception ex) {
                throw new Exception("Error mostrando los puestos: " + ex.Message);
            }
            return dts.Tables["Puestos"];
        }

        public DataTable ListarProyecto() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarProyecto";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Proyecto");
            } catch (Exception ex) {
                throw new Exception("Error mostrando proyecto: " + ex.Message);
            }
            return dts.Tables["Proyecto"];
        }

        public int NewIdPersonaInteres() {
            int newid;
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.NewPerson";

                var returnParameter = cmd.Parameters.Add("@NewId", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.Output;


                con.Open();
                cmd.ExecuteNonQuery();
                newid = (int)cmd.Parameters["@NewId"].Value; ;

            } catch (Exception ex) {
                throw new Exception("Error generando nuevo Id de persona: " + ex.Message);
            }
            return newid;
        }
    }
}
