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
    
    public partial class geo_img_ubicacion
    {
        public int id { get; set; }
        public string url_img { get; set; }
        public string name { get; set; }
        public string create_usr { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<int> id_geo_ubi { get; set; }
        public byte[] value { get; set; }
    
        public virtual geo_ubicacion geo_ubicacion { get; set; }
    }
}
