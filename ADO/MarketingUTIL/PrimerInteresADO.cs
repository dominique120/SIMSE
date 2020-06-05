using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.MarketingUTIL {
    public class PrimerInteresADO {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable ListarPrimerInteres() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MARKETING.ListarPrimerInteres";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "PrimerInteres");
            } catch (Exception ex) {
                throw new Exception("Error mostrando los tipos de Primer Interés: " + ex.Message);
            }
            return dts.Tables["PrimerInteres"];
        }
    }
}
