//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADO
{
    using System;
    
    public partial class ListarPlanosPorProyectoTipo_Result
    {
        public int id_documento { get; set; }
        public string revision { get; set; }
        public string nom_tipo_plano { get; set; }
        public string dibujadoPor { get; set; }
        public string revisadoPor { get; set; }
        public string nom_plano { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public Nullable<System.DateTime> fecha_revision { get; set; }
        public Nullable<System.DateTime> fecha_envio { get; set; }
        public string path_plano { get; set; }
    }
}