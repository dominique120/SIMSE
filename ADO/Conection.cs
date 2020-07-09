using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ADO
{
    public class Conection
    {
        SqlConnection con = new SqlConnection();
        public string GetCon() {
            bool failed2017 = false;
            bool failed2019 = false;
            string strCon = ConfigurationManager.ConnectionStrings["GRUBAL"].ConnectionString;
            string fallback = ConfigurationManager.ConnectionStrings["GRUBAL2017"].ConnectionString;

            if (object.ReferenceEquals(strCon, string.Empty) || object.ReferenceEquals(fallback, string.Empty)) {
                return string.Empty;
            } 

            // test SQL 2019 database:
            try {
                con.ConnectionString = strCon;
                con.Open();
                con.Close();
            } catch (SqlException) {
                failed2019 = true;
            }

            //test SQL 2017 database
            try {
                con.ConnectionString = fallback;
                con.Open();
                con.Close();
            } catch (SqlException) {
                failed2017 = true;
            }

            if (failed2019 && failed2017) {
                return string.Empty;
            } else if (failed2019 == false) {
                return strCon;
            } else if (failed2017 == false) {
                return fallback;
            } else {
                return string.Empty;
            }
        }
    }
}
