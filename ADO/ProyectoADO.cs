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


        public DataTable ListarProyectos() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PROYECTO.ListarProyectos";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Proyectos");
            } catch (Exception ex) {
                throw new Exception("Error mostrando proyecto: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
            return dts.Tables["Proyectos"];
        }

        public Boolean NuevoProyecto(ProyectoBE proyBE)
        { 
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PROYECTO.ProyectoNew";

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

        public DataTable ListarDivisiones() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PROYECTO.ListarDivisiones";

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Divisiones");
            } catch (Exception ex) {
                throw new Exception("Error mostrando las divisiones: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
            return dts.Tables["Divisiones"];
        }

        public ProyectoBE ListarPersonasDeInteresPorId(int idProyecto) {
            ProyectoBE proyBE = new ProyectoBE();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PROYECTO.ListarProyectoPorId";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_proyecto", idProyecto);

                con.Open();
                SqlDataReader dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true) {
                    dtr.Read();
                    proyBE.Dir_proyecto = dtr["dir_proyecto"].ToString();
                    proyBE.Fecha_inicio = (DateTime)dtr["fecha_inicio"];
                    proyBE.Fecha_fin = (DateTime)dtr["fecha_fin"];
                    proyBE.Id_cliente = int.Parse(dtr["id_cliente"].ToString());
                    proyBE.Id_division = int.Parse(dtr["id_division"].ToString());
                    proyBE.Id_proyecto = int.Parse(dtr["id_proyecto"].ToString());
                    proyBE.Nom_proyecto = dtr["nom_proyecto"].ToString();

                } else {
                    throw new Exception("Error al buscar el proyecto.");
                }
                dtr.Close();

            } catch (Exception ex) {
                throw new Exception(ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
                cmd.Parameters.Clear();
            }
            return proyBE;
        }

        public Boolean ModificarProyecto(ProyectoBE proyBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PROYECTO.UpdateProyecto";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_proyecto", proyBE.Id_proyecto);
                cmd.Parameters.AddWithValue("@id_cliente", proyBE.Id_cliente);
                cmd.Parameters.AddWithValue("@id_division", proyBE.Id_division);
                cmd.Parameters.AddWithValue("@nom_proyecto", proyBE.Nom_proyecto);
                cmd.Parameters.AddWithValue("@dir_proyecto", proyBE.Dir_proyecto);
                cmd.Parameters.AddWithValue("@fecha_fin", proyBE.Fecha_fin);
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

