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
    
    public partial class ENTREGA_FINAL
    {
        public int id_documento { get; set; }
        public int id_proyecto { get; set; }
        public int id_encargado { get; set; }
        public string path_scan_reporte { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        public virtual ID_DOCUMENTO ID_DOCUMENTO1 { get; set; }
        public virtual EMPLEADO EMPLEADO { get; set; }
        public virtual PROYECTO PROYECTO { get; set; }
    }
}
