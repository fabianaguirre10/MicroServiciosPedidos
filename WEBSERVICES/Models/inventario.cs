//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEBSERVICES.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class inventario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public inventario()
        {
            this.inventariodetalles = new HashSet<inventariodetalles>();
        }
    
        public int id { get; set; }
        public string codcliente { get; set; }
        public string codvendedor { get; set; }
        public Nullable<System.DateTime> fechainventario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inventariodetalles> inventariodetalles { get; set; }
    }
}
