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
    
    public partial class Ventas_netas_historia
    {
        public int id { get; set; }
        public string TIPO_TRANS { get; set; }
        public string FACTURA { get; set; }
        public string CLIENTE { get; set; }
        public string LINEA { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string VENDEDOR { get; set; }
        public string PRODUCTO { get; set; }
        public string CODPROD { get; set; }
        public Nullable<decimal> UNIDAD { get; set; }
        public Nullable<decimal> CAJAS { get; set; }
        public Nullable<decimal> CAJAS_MAD { get; set; }
        public string TONELAJE { get; set; }
        public Nullable<decimal> SUBTOTAL { get; set; }
        public Nullable<decimal> DESCTO { get; set; }
        public Nullable<decimal> TOTAL { get; set; }
    }
}
