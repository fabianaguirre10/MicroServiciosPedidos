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
    
    public partial class pedidosItems
    {
        public int C_id { get; set; }
        public int idPedido { get; set; }
        public string idArticulo { get; set; }
        public Nullable<decimal> cantidad { get; set; }
        public Nullable<decimal> importeUnitario { get; set; }
        public Nullable<decimal> porcDescuento { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<int> transferido { get; set; }
        public Nullable<decimal> ppago { get; set; }
        public Nullable<decimal> nespecial { get; set; }
        public string num_factura { get; set; }
        public string numero_factura { get; set; }
        public string formapago { get; set; }
        public string unidad { get; set; }
    
        public virtual PEDIDOS PEDIDOS { get; set; }
    }
}