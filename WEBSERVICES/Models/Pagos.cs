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
    
    public partial class Pagos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pagos()
        {
            this.ChequePagos = new HashSet<ChequePagos>();
            this.PagosDetalles = new HashSet<PagosDetalles>();
        }
    
        public int Idpago { get; set; }
        public string CodCliente { get; set; }
        public Nullable<decimal> ValorTotalPago { get; set; }
        public string FormaPago { get; set; }
        public string Fecha { get; set; }
        public string foto { get; set; }
        public byte[] imagen { get; set; }
        public string idvendedor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChequePagos> ChequePagos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagosDetalles> PagosDetalles { get; set; }
    }
}
