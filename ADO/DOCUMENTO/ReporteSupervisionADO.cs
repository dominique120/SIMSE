﻿using BE.DOCUMENTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.DOCUMENTO {
    public class ReporteSupervisionADO {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        
        public DataTable ListarReporteSupervisionFull() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarReporteSupervisionFull";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "ReporteSupervision");
            } catch (Exception ex) {
                throw new Exception("Error mostrando Reportes de Supervision: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
            return dts.Tables["ReporteSupervision"];
        }

        public DataTable ListarReporteSupervisionProyectoSupervisor(int id_proyecto, int id_supervisor) {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarReporteSupervisionPorProyectoEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_proyecto", id_proyecto);
                cmd.Parameters.AddWithValue("@id_supervisor", id_supervisor);

                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "ReporteSupervision");
                return dts.Tables["ReporteSupervision"];
            } catch (SqlException ex) {
                throw new Exception("Error mostrando Reportes de Supervision: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
        }

        public DataTable ListarReporteSupervisionProyecto(int id_proyecto) {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarReporteSupervisionPorProyecto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_proyecto", id_proyecto);


                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "ReporteSupervision");
                return dts.Tables["ReporteSupervision"];
            } catch (SqlException ex) {
                throw new Exception("Error mostrando Reportes de Supervision: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
        }


        public Boolean ReporteSupervisionNew(ReporteSupervisionBE rsBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DOCUMENTO.ReporteSupervisionNew";
            bool success;

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_proyecto", rsBE.Id_proyecto);
                cmd.Parameters.AddWithValue("@id_supervisor", rsBE.Id_supervisor);
                cmd.Parameters.AddWithValue("@fecha_reporte", rsBE.Fecha_reporte);
                cmd.Parameters.AddWithValue("@detalles_reporte", rsBE.Detalles_reporte);
                cmd.Parameters.AddWithValue("@path_scan_reporte", rsBE.Path_scan_reporte);

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

        public Boolean EliminarReporteSupervision(int idDocumento) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DOCUMENTO.EliminarReporteSupervision";
            bool success;

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_documento", idDocumento);

                con.Open();
                cmd.ExecuteNonQuery();

                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception("No se pudo eliminar el documento, tiene data relacionada a ella" + x.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
                cmd.Parameters.Clear();
            }
            return success;
        }

        public Boolean ModificarReporteSupervision(ReporteSupervisionBE rsBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DOCUMENTO.ModificarReporteSupervision";
            bool success;

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_documento", rsBE.Id_documento);
                cmd.Parameters.AddWithValue("@id_proyecto", rsBE.Id_proyecto);
                cmd.Parameters.AddWithValue("@id_supervisor", rsBE.Id_supervisor);
                cmd.Parameters.AddWithValue("@fecha_reporte", rsBE.Fecha_reporte);
                cmd.Parameters.AddWithValue("@detalles_reporte", rsBE.Detalles_reporte);
                cmd.Parameters.AddWithValue("@path_scan_reporte", rsBE.Path_scan_reporte);

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



        public ReporteSupervisionBE ListarReporteSupervisionPorId(int idDocumento) {
            ReporteSupervisionBE rpBE = new ReporteSupervisionBE();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarReporteSupervisionPorId";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_documento", idDocumento);

                con.Open();
                SqlDataReader dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true) {
                    dtr.Read();
                    rpBE.Id_documento = int.Parse(dtr["id_documento"].ToString());
                    rpBE.Id_proyecto = int.Parse(dtr["id_proyecto"].ToString());
                    rpBE.Id_supervisor = int.Parse(dtr["id_supervisor"].ToString());
                    rpBE.Fecha_reporte = Convert.ToDateTime(dtr["fecha_reporte"]);
                    rpBE.Detalles_reporte = dtr["detalles_reporte"].ToString();
                    rpBE.Path_scan_reporte = dtr["path_scan_reporte"].ToString();
                } else {
                    throw new Exception("Error al buscar el documento.");
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
            return rpBE;
        }
    }
}
