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
    using System.Collections.Generic;
    
    public partial class PERSONA_DE_INTERES
    {
        public int id_persona { get; set; }
        public int id_directorio { get; set; }
        public int id_proyecto { get; set; }
        public short puesto { get; set; }
        public string nom_persona { get; set; }
    
        public virtual ID_PERSONA ID_PERSONA1 { get; set; }
        public virtual DIRECTORIO DIRECTORIO { get; set; }
        public virtual PROYECTO PROYECTO { get; set; }
        public virtual PUESTO PUESTO1 { get; set; }
    }
}