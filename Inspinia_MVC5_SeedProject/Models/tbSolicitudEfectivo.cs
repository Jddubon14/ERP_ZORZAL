//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_ZORZAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbSolicitudEfectivo
    {
        public int solef_Id { get; set; }
        public short cja_Id { get; set; }
        public decimal solef_MontoSolicitud { get; set; }
        public int solef_UsuarioCrea { get; set; }
        public System.DateTime solef_FechaCrea { get; set; }
        public Nullable<int> solef_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> solef_FechaModifica { get; set; }
    
        public virtual tbCaja1 tbCaja1 { get; set; }
    }
}