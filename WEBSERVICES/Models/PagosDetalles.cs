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
    
    public partial class PagosDetalles
    {
        public int idpagodetalle { get; set; }
        public int idpago { get; set; }
        public string Numfactura { get; set; }
        public Nullable<decimal> TotalFactura { get; set; }
        public Nullable<decimal> PagoRegistrado { get; set; }
    
        public virtual Pagos Pagos { get; set; }
    }
}
