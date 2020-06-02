using BE.PROYECTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    public class ProyectoADO
    {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        Boolean success = false;

        public Boolean NuevoProyecto(ProyectoBE proyBE)
        { 
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PROYECTO.NuevoProyecto";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_cliente", proyBE.Id_cliente);
                cmd.Parameters.AddWithValue("@id_division", proyBE.Id_division);
                cmd.Parameters.AddWithValue("@nom_proyecto", proyBE.Nom_proyecto);
                cmd.Parameters.AddWithValue("@dir_proyecto", proyBE.Dir_proyecto);
                cmd.Parameters.AddWithValue("@fecha_inicio", proyBE.Fecha_inicio);

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

