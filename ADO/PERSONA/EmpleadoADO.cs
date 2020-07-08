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

        public DataTable ListarEmpleadosFull() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarEmpleadoFull";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Empleados");
            } catch (Exception ex) {
                throw new Exception("Error mostrando empleados: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
            return dts.Tables["Empleados"];
        }

        public Boolean NuevoEmpleado(EmpleadoBE empBE)
        {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.NewEmpleado";

            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_persona", empBE.Id_persona);
                cmd.Parameters.AddWithValue("@puesto_empleado", empBE.Puesto_empleado);
                cmd.Parameters.AddWithValue("@doc_oficial", empBE.Doc_oficial);
                cmd.Parameters.AddWithValue("@ruc_empleado", empBE.Ruc_empleado);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", empBE.Fecha_nacimiento);
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

        public EmpleadoBE ListarEmpleadosPorId(int idEmpleado) {
            EmpleadoBE empBE = new EmpleadoBE();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarEmpleadoPorId";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_persona", idEmpleado);

                con.Open();
                SqlDataReader dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true) {
                    dtr.Read();
                    empBE.Id_persona = int.Parse(dtr["id_persona"].ToString());
                    empBE.Primer_ape = dtr["primer_ape"].ToString();
                    empBE.Segundo_ape = dtr["segundo_ape"].ToString();
                    empBE.Primer_nom = dtr["primer_nom"].ToString();
                    empBE.Segundo_nom = dtr["segundo_nom"].ToString();
                    empBE.Doc_oficial = dtr["doc_oficial"].ToString();
                    empBE.Ruc_empleado = dtr["ruc_empleado"].ToString();
                    empBE.Puesto_empleado = short.Parse(dtr["puesto_empleado"].ToString());
                    empBE.Fecha_inicio = (DateTime)dtr["fecha_inicio"];
                    empBE.Fecha_nacimiento = (DateTime)dtr["fecha_nacimiento"];

                } else {
                    throw new Exception("Error al buscar al empleado.");
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
            return empBE;
        }

        public Boolean ModificarEmpleado(EmpleadoBE empBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.ModificarEmpleado";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_persona", empBE.Id_persona);
                cmd.Parameters.AddWithValue("@puesto_empleado", empBE.Puesto_empleado);
                cmd.Parameters.AddWithValue("@doc_oficial", empBE.Doc_oficial);
                cmd.Parameters.AddWithValue("@ruc_empleado", empBE.Ruc_empleado);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", empBE.Fecha_nacimiento);
                cmd.Parameters.AddWithValue("@fecha_inicio", empBE.Fecha_inicio);
                cmd.Parameters.AddWithValue("@primer_nom", empBE.Primer_nom);
                cmd.Parameters.AddWithValue("@primer_ape", empBE.Primer_ape);
                cmd.Parameters.AddWithValue("@segundo_nom", empBE.Segundo_nom);
                cmd.Parameters.AddWithValue("@segundo_ape", empBE.Segundo_ape);

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

        public Boolean UpdateEstado(int idEmpleado, bool estado) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.UpdateEstado";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_persona", idEmpleado);
                cmd.Parameters.AddWithValue("@estado", estado);

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

        public bool RevisarEstado(int idEmpleado) {
            bool estado;
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.EmpleadoSelectEstado ";

                cmd.Parameters.Clear();

                SqlParameter param = new SqlParameter("@id_Persona", SqlDbType.Int);
                param.Direction = ParameterDirection.Input;
                param.Value = idEmpleado;
                cmd.Parameters.Add(param);

                SqlParameter retval = cmd.Parameters.Add("@estado", SqlDbType.Bit);
                retval.Direction = ParameterDirection.Output;

                con.Open();
                cmd.ExecuteNonQuery();

                estado = (bool)cmd.Parameters["@estado"].Value;

            } catch (Exception ex) {
                throw new Exception("Error obteniendo el estado: " + ex.Message);
            } finally {
                con.Close();
                cmd.Parameters.Clear();
            }
            return estado;
        }

    }
}
