//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inspinia_MVC5_SeedProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbListadoPrecioDetalle
    {
        public int listp_Id { get; set; }
        public string prod_Codigo { get; set; }
        public decimal lispd_PrecioMayorista { get; set; }
        public decimal lispd_Preciominorista { get; set; }
        public System.DateTime lispd_Fechainiciovigencia { get; set; }
        public System.DateTime lispd_Fechaifinalvigencia { get; set; }
        public Nullable<decimal> lispd_DescCaja { get; set; }
        public Nullable<decimal> lispd_DescGerente { get; set; }
        public string lispd_UsuarioCrea { get; set; }
        public System.DateTime lispd_FechaCrea { get; set; }
        public string lispd_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> lispd_FechaModifica { get; set; }
    
        public virtual tbListaPrecio tbListaPrecio { get; set; }
    }
}