//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADMIN.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class tblRol
    {
        public int idRol { get; set; }
        [DisplayName("Nombre (ES)")]
        [StringLength(50,ErrorMessage = "Se aceptan un maximo de 50 caracteres")]
        public string vNameEn { get; set; }
        [DisplayName("Nombre (EN)")]
        [StringLength(50,ErrorMessage = "Se aceptan un maximo de 50 caracteres")]
        public string vNameEs { get; set; }
        [DisplayName("Fecha de creación")]
        public Nullable<System.DateTime> dCreateDate { get; set; }
        public Nullable<System.DateTime> dUpdateDate { get; set; }
        public string vCreateUser { get; set; }
        public string vUpdateUser { get; set; }
        [DisplayName("Activo")]
        public bool bActive { get; set; }
    }
}
