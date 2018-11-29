﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inspinia_MVC5_SeedProject.Models
{
    [MetadataType(typeof(_CuentasBancoMetaData))]

    public partial class tbCuentasBanco
    {
    }     

    public class _CuentasBancoMetaData
    {
        [Display(Name = "Código Cuenta de Banco")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public int bcta_Id { get; set; }
        [Display(Name = "Código Banco")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public int ban_Id { get; set; }
        [Display(Name = "Codigo de Moneda")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public int mnda_Id { get; set; }
        [Display(Name = "Nombre Contacto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string bcta_NombreContacto { get; set; }
        [Display(Name = "Tipo Cuenta")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string bcta_TipoCuenta { get; set; }
        [Display(Name = "Total Crédito")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public decimal bcta_TotalCredito { get; set; }
        [Display(Name = "Total Debito")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public decimal bcta_TotalDebito { get; set; }
        [Display(Name = "Saldo Cuenta")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public decimal bcta_SaldoCuenta { get; set; }
        [Display(Name = "Fecha Apertura")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime bcta_FechaApertura { get; set; }
        [Display(Name = "Número Cuenta")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string bcta_Num { get; set; }
        [Display(Name = "Usuario Creación")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string bcta_UsuarioCrea { get; set; }
        [Display(Name = "Fecha Creación")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime bcta_FechaCrea { get; set; }
        [Display(Name = "Usuario Modificación")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public string bcta_UsuarioModifica { get; set; }
        [Display(Name = "Fecha Modificación")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> bcta_FechaModifica { get; set; }
    }

}