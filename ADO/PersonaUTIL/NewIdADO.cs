using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.PersonaUTIL {
    public class NewIdADO {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public int NewId() {
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
            } finally {
                con.Close();
            }
            return newid;
        }
    }
}

