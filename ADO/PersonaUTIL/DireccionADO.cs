using BE._EFE;
using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.PersonaUTIL.Direcciones {
    public class DireccionADO {
        grubalEntities db = new grubalEntities();

        public List<DistritoEFE> ListarDistritos() {
            List<DistritoEFE> list = new List<DistritoEFE>();
            DistritoEFE d;
            try {
                var q = db.ListarDistritos();
                foreach(var r in q) {
                    d = new DistritoEFE(r.id_ciudad, r.id_distrito, r.nom_distrito);
                    list.Add(d);
                }
                return list;
            } catch (Exception ex) {
                throw new Exception("Error mostrando los distritos: " + ex.Message);
            } 
        }

        public List<DistritoEFE> ListarDistritosPorIdCiudad(int idCiudad) {
            List<DistritoEFE> list = new List<DistritoEFE>();
            DistritoEFE d;
            try {
                var q = db.ListarDistritoPorIdPorCiudad(idCiudad);
                foreach (var r in q) {
                    d = new DistritoEFE(r.id_ciudad, r.id_distrito, r.nom_distrito);
                    list.Add(d);
                }
                return list;
            } catch (Exception ex) {
                throw new Exception("Error mostrando los distritos: " + ex.Message);
            } 
        }

        public List<CiudadEFE> ListarCiudades() {
            List<CiudadEFE> list = new List<CiudadEFE>();
            CiudadEFE c;
            try {
                var q = db.ListarCiudades();
                foreach (var r in q) {
                    c = new CiudadEFE(r.id_ciudad,r.id_region,r.nom_ciudad);
                    list.Add(c);
                }
                return list;
            } catch (Exception ex) {
                throw new Exception("Error mostrando los ciudades: " + ex.Message);
            } 
        }

        public List<CiudadEFE> ListarCiudadesPorIdRegion(int idRegion) {
            List<CiudadEFE> list = new List<CiudadEFE>();
            CiudadEFE c;
            try {
                var q = db.ListarCiudadesPorIdRegion(idRegion);
                foreach (var r in q) {
                    c = new CiudadEFE(r.id_ciudad, r.id_region, r.nom_ciudad);
                    list.Add(c);
                }
                return list;
            } catch (Exception ex) {
                throw new Exception("Error mostrando las ciudades: " + ex.Message);
            } 
        }

        public List<RegionEFE> ListarRegiones() {
            List<RegionEFE> list = new List<RegionEFE>();
            RegionEFE c;
            try {
                var q = db.ListarRegiones();
                foreach (var r in q) {
                    c = new RegionEFE(r.id_region,r.id_pais,r.nom_region);
                    list.Add(c);
                }
                return list;
            } catch (Exception ex) {
                throw new Exception("Error mostrando los regiones: " + ex.Message);
            } 
        }

        public List<RegionEFE> ListarRegionesPorIdPais(int idPais) {
            List<RegionEFE> list = new List<RegionEFE>();
            RegionEFE c;
            try {
                var q = db.ListarRegionesPorIdPais(idPais);
                foreach (var r in q) {
                    c = new RegionEFE(r.id_region, r.id_pais, r.nom_region);
                    list.Add(c);
                }
                return list;
            } catch (Exception ex) {
                throw new Exception("Error mostrando las regiones: " + ex.Message);
            } 
        }

        public DataTable ListarPaises() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarPaises";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Países");
            } catch (Exception ex) {
                throw new Exception("Error mostrando los países: " + ex.Message);
            } 
        }

        public DataTable ListarDireccionesTipos() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarDireccionesTipos";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "DireccionesTipos");
            } catch (Exception ex) {
                throw new Exception("Error mostrando los tipos de dirección: " + ex.Message);
            } 
        }

        Boolean success = false;
        public Boolean DireccionNew(DireccionBE d) {
            try {
                db.DireccionNew(d.Tipo_direccion, d.Id_persona, (byte)d.Dir_pais, d.Dir_provincia, d.Dir_ciudad, d.Dir_distrito, d.Dir_linea_1, d.Dir_linea_2, d.Dir_codigo_postal);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;
        }

        public DataTable ListarDireccionesFull() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarDireccionesFull";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Direcciones");
            } catch (Exception ex) {
                throw new Exception("Error mostrando las direcciones: " + ex.Message);
            } 
        }

        public DataTable ListarPersonasConDirecciones() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarPersonasConDirecciones";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "PersonasConDirecciones");
            } catch (Exception ex) {
                throw new Exception("Error mostrando las personas con direcciones: " + ex.Message);
            } 
        }

        public DataTable ListarDireccionesFullPorId(int idPersona) {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarDireccionesFullPorId";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_persona", idPersona);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Direcciones");
            } catch (Exception ex) {
                throw new Exception("Error mostrando las direcciones: " + ex.Message);
            } 
        }

        public DireccionBE SelectDireccion(int idDireccion) {
            DireccionBE dirBE;
            try {
                var q =db.SelectDireccion(idDireccion).FirstOrDefault();
                dirBE = new DireccionBE(q.tipo_direccion, q.id_persona, q.dir_pais, q.dir_provincia, q.dir_ciudad, q.dir_distrito, q.dir_linea_1, q.dir_linea_2, q.dir_codigo_postal);
            } catch (Exception ex) {
                throw new Exception("Error mostrando las direcciones: " + ex.Message);
            } 
            return dirBE;
        }

        public Boolean ModificarDireccion(DireccionBE d) {
            try {
                db.ModificarDireccion(d.Id_direccion, d.Tipo_direccion, d.Id_persona, (byte)d.Dir_pais, d.Dir_provincia, d.Dir_ciudad, d.Dir_distrito, d.Dir_linea_1, d.Dir_linea_2, d.Dir_codigo_postal);
                success = true;
            } catch (Exception x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;
        }

        public Boolean EliminarDireccion(int idDireccion) {
            try {
                db.EliminarDireccion(idDireccion);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;
        }
    }
}
