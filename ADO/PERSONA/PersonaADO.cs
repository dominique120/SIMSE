using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.PERSONA {
    public class PersonaADO {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();


        // TODO: ListarPersonasALL returns an INT, it should return the contents of the selected table
        public List<> ListarPersonasALL() {
            grubalEntities db = new grubalEntities();
            /*
            try {
                var q = db.ListarPersonasALL();

                foreach(var r in q) {

                }

                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarPersonasALL";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Personas");
            } catch (Exception ex) {
                throw new Exception("Error mostrando las personas: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
            return dts.Tables["Personas"];
            */
        }
    }
}
