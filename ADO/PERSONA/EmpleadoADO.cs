using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO {
    public class EmpleadoADO {
        Boolean success = false;

        public List<EmpleadoBE> ListarEmpleadosFull() {
            grubalEntities db = new grubalEntities();
            List<EmpleadoBE> list = new List<EmpleadoBE>();
            try {
                var query = db.ListarEMpleadoFull();

                // TODO: Implment conversion from puesto_empleado from strign to short
                // its returning a string but expects the id
                // TODO: Nombre Completeo comes as one string inseat of in its individual components
                // PROPOSAL: Modify SP to return additional required fields withut affecting already mapped fields
                foreach (var r in query) {
                    EmpleadoBE be = new EmpleadoBE {
                        Doc_oficial = r.Documento,
                        Id_persona = r.ID_Empleado,
                        Ruc_empleado = r.RUC,
                        Fecha_inicio = r.Fecha_Inicio,
                        Fecha_nacimiento = r.Fecha_Nacimiento,
                        Primer_nom = r.Nombre_Completo,
                        Estado = (bool)r.Activo
                    };
                    list.Add(be);
                }
                return list;

            } catch (Exception ex) {
                throw new Exception("Error mostrando empleados: " + ex.Message);
            }
        }

        public Boolean NuevoEmpleado(EmpleadoBE e) {
            grubalEntities db = new grubalEntities();

            try {

                db.NewEmpleado(e.Id_persona, e.Puesto_empleado, e.Doc_oficial, e.Ruc_empleado, e.Fecha_nacimiento,
                    e.Fecha_inicio, e.Primer_nom, e.Segundo_nom, e.Primer_ape, e.Segundo_ape, e.Estado);

                success = true;

            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;
        }

        public EmpleadoBE ListarEmpleadosPorId(int idEmpleado) {
            EmpleadoBE e;
            grubalEntities db = new grubalEntities();

            try {
                var q = db.ListarEmpleadoPorId(idEmpleado).FirstOrDefault();

                // TODO: Return the state of the employee
                e = new EmpleadoBE {
                    Doc_oficial = q.doc_oficial,
                    Id_persona = q.id_persona,
                    Ruc_empleado = q.ruc_empleado,
                    Fecha_inicio = q.fecha_inicio,
                    Fecha_nacimiento = q.fecha_nacimiento,
                    Primer_nom = q.primer_nom,
                    Segundo_ape = q.segundo_ape,
                    Primer_ape = q.primer_ape,
                    Puesto_empleado = q.puesto_empleado
                };

            } catch (Exception ex) {
                throw new Exception(ex.Message);
            } 
            return e;
        }

        public Boolean ModificarEmpleado(EmpleadoBE e) {
            grubalEntities db = new grubalEntities();

            try {
                // TODO: Add employee state
                db.ModificarEmpleado(e.Id_persona, e.Puesto_empleado, e.Doc_oficial, e.Ruc_empleado, e.Fecha_nacimiento,
    e.Fecha_inicio, e.Primer_nom, e.Segundo_nom, e.Primer_ape, e.Segundo_ape);

                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;
        }

        public Boolean UpdateEstado(int idEmpleado, bool estado) {
            grubalEntities db = new grubalEntities();
            try {
                db.UpdateEstado(idEmpleado, estado);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;
        }

        public bool RevisarEstado(int idEmpleado) {
            grubalEntities db = new grubalEntities();

            bool estado = true;

            // TODO: Implement method and review SP

            /*
            try {

                db.EmpleadoSelectEstado(idEmpleado);

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
            }*/
            return estado;
        }

    }
}
