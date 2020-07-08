using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.DOCUMENTO {
    class PlanosADO {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        Boolean success = false;
        public DataTable ListarReporteSupervisionFull() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarPlanosFull";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Planos");
            } catch (Exception ex) {
                throw new Exception("Error mostrando los Planos: " + ex.Message);
            }
            return dts.Tables["Planos"];
        }
    }
}
