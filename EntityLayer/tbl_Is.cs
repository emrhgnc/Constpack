//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Is
    {
        public int intId { get; set; }
        public int intIsId { get; set; }
        public int intSorumlu { get; set; }
        public string strOzellik { get; set; }
        public int intMiktar { get; set; }
        public int intMahalId { get; set; }
        public bool blTamamlandi { get; set; }
    
        public virtual tbl_Is_Havuzu tbl_Is_Havuzu { get; set; }
        public virtual tbl_Kullanici tbl_Kullanici { get; set; }
        public virtual tbl_Mahal tbl_Mahal { get; set; }
    }
}
