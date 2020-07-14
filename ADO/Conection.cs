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
        public string GetCon() {

            string strCon = ConfigurationManager.ConnectionStrings["GRUBAL"].ConnectionString;

            if (object.ReferenceEquals(strCon, string.Empty)) {
                return string.Empty;
            } else {
                return strCon;
            }
        }
    }
}
