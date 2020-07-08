using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.DOCUMENTO {
    class EntregaFinalADO {
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
                cmd.CommandText = "DOCUMENTO.ListarEntregaFinalFull";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "EntregaFinal");
            } catch (Exception ex) {
                throw new Exception("Error mostrando las Entregas Finales: " + ex.Message);
            }
            return dts.Tables["EntregaFinal"];
        }
    }
}
