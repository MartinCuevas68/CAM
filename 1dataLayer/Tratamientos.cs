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
    
    public partial class Tratamientos
    {
        public int id_tratamiento { get; set; }
        public int id_cartilla_medica { get; set; }
        public string Tratamiento { get; set; }
    
        public virtual tabla_medica tabla_medica { get; set; }
    }
}
