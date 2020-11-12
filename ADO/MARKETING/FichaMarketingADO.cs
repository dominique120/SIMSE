using BE.MARKETING;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.MARKETING {
    public class FichaMarketingADO {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        Boolean success = false;

        public Boolean FichaMarketingNew(FichaMarketingBE fmbe) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MARKETING.FichaMarketingNew";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_ficha_marketing", fmbe.Id_ficha_marketing);
                cmd.Parameters.AddWithValue("@id_persona_fuente", fmbe.Id_persona_fuente);
                cmd.Parameters.AddWithValue("@forma_contacto_inical", fmbe.Forma_contacto_inical);
                cmd.Parameters.AddWithValue("@primer_interes", fmbe.Primer_interes);
                cmd.Parameters.AddWithValue("@fecha_primer_contacto", fmbe.Fecha_primer_contacto);
                cmd.Parameters.AddWithValue("@fecha_ultimo_contacto", fmbe.Fecha_ultimo_contacto);

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
