//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IngresosHospital
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Paciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Paciente()
        {
            this.T_Ingresos = new HashSet<T_Ingresos>();
        }
    
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Ingresos> T_Ingresos { get; set; }
    }
}
