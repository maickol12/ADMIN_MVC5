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
    using System.Collections.Generic;
    
    public partial class tblSubMenu
    {
        public int idSubMenu { get; set; }
        public string NameEs { get; set; }
        public string NameEn { get; set; }
        public string Ruta { get; set; }
        public Nullable<int> idMenu { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual tblMenu tblMenu { get; set; }
    }
}
