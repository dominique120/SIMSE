using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    public class EmpleadoADO
    {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        Boolean success = false;

        public Boolean NuevoEmpleado(EmpleadoBE empBE)
        {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.NuevoEmpleado";

            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@puesto", empBE.Puesto_empleado);
                cmd.Parameters.AddWithValue("@doc_oficial", empBE.Doc_oficial);
                cmd.Parameters.AddWithValue("@ruc", empBE.Ruc_empleado);
                cmd.Parameters.AddWithValue("@fecha_nac", empBE.Fecha_nacimiento);
                cmd.Parameters.AddWithValue("@fecha_inicio", empBE.Fecha_inicio);
                cmd.Parameters.AddWithValue("@primer_nom", empBE.Primer_nom);
                cmd.Parameters.AddWithValue("@primer_ape", empBE.Primer_ape);
                cmd.Parameters.AddWithValue("@segundo_nom", empBE.Segundo_nom);
                cmd.Parameters.AddWithValue("@segundo_ape", empBE.Segundo_ape);

                con.Open();
                cmd.ExecuteNonQuery();

                success = true;

            }
            catch (SqlException x)
            {
                success = false;
                throw new Exception(x.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                cmd.Parameters.Clear();
            }
            return success;
        }

    }
}
