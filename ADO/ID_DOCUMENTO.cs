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
    
    public partial class ID_DOCUMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ID_DOCUMENTO()
        {
            this.ENTREGA_FINAL = new HashSet<ENTREGA_FINAL>();
            this.PLANOes = new HashSet<PLANO>();
            this.REPORTE_SUPERVISION = new HashSet<REPORTE_SUPERVISION>();
            this.REPORTE_TECNICO = new HashSet<REPORTE_TECNICO>();
        }
    
        public int id_documento1 { get; set; }
        public System.Guid uid { get; set; }
    
        public virtual COTIZACION COTIZACION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTREGA_FINAL> ENTREGA_FINAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLANO> PLANOes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPORTE_SUPERVISION> REPORTE_SUPERVISION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPORTE_TECNICO> REPORTE_TECNICO { get; set; }
    }
}
