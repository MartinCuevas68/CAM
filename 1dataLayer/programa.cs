//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _1dataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class programa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public programa()
        {
            this.alumno = new HashSet<alumno>();
            this.turnos = new HashSet<turnos>();
            this.recursos = new HashSet<recursos>();
        }
    
        public int id_programa { get; set; }
        public string nombre_programa { get; set; }
        public string tiempo { get; set; }
        public string secuencia { get; set; }
        public string criterios { get; set; }
        public string objetivo { get; set; }
        public string modulos { get; set; }
        public string proyecto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alumno> alumno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<turnos> turnos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<recursos> recursos { get; set; }
    }
}
