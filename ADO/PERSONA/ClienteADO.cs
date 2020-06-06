using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO {
    public class ClienteADO {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        Boolean success = false;

        public DataTable ListarClientesFull() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarClientesFull";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Clientes");
            } catch (Exception ex) {
                throw new Exception("Error mostrando clientes: " + ex.Message);
            }
            return dts.Tables["Clientes"];
        }

        public Boolean ClienteNew(ClienteBE cliBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.ClienteNew";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_persona", cliBE.Id_persona);
                cmd.Parameters.AddWithValue("@marketing", cliBE.Marketing);
                cmd.Parameters.AddWithValue("@nom_cliente", cliBE.Nom_cliente);
                cmd.Parameters.AddWithValue("@doc_oficial", cliBE.Doc_oficial);

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

        public Boolean EliminarCliente(int IdCliente, int IdFichaMarketing) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.EliminarCliente";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_persona", IdCliente);
                cmd.Parameters.AddWithValue("@id_ficha_marketing", IdFichaMarketing);

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

        public Boolean ModificarCliente(ClienteBE cliBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.ModificarCliente";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_persona", cliBE.Id_persona);
                cmd.Parameters.AddWithValue("@marketing", cliBE.Marketing);
                cmd.Parameters.AddWithValue("@nom_cliente", cliBE.Nom_cliente);
                cmd.Parameters.AddWithValue("@doc_oficial", cliBE.Doc_oficial);

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

        public DataTable ListarClientes() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarClientes";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Clientes");
            } catch (Exception ex) {
                throw new Exception("Error mostrando los clientes: " + ex.Message);
            }
            return dts.Tables["Clientes"];
        }

        public ClienteBE ListarClientesPorId(int idCliente) {
            ClienteBE cliBE = new ClienteBE();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarClientesPorId";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_persona", idCliente);

                con.Open();
                SqlDataReader dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true) {
                    dtr.Read();
                    cliBE.Id_persona = int.Parse(dtr["id_persona"].ToString());
                    cliBE.Marketing = int.Parse(dtr["marketing"].ToString());
                    cliBE.Nom_cliente = dtr["nom_cliente"].ToString();
                    cliBE.Doc_oficial = dtr["doc_oficial"].ToString();
                } else {
                    throw new Exception("Error al buscar al cliente.");
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
            return cliBE;
        }
    }
}
