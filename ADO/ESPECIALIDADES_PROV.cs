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
    
    public partial class ESPECIALIDADES_PROV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESPECIALIDADES_PROV()
        {
            this.PROVEEDORs = new HashSet<PROVEEDOR>();
        }
    
        public int id_especialidad { get; set; }
        public string nom_especialidad { get; set; }
        public string desc_especialidad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROVEEDOR> PROVEEDORs { get; set; }
    }
}
