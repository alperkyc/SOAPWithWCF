//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceResults
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sonuclar
    {
        public int sonucId { get; set; }
        public Nullable<int> ogrenciId { get; set; }
        public Nullable<int> turId { get; set; }
        public Nullable<int> yilId { get; set; }
        public Nullable<int> sonuc { get; set; }
    
        public virtual Ogrenciler Ogrenciler { get; set; }
        public virtual Turler Turler { get; set; }
        public virtual Yillar Yillar { get; set; }
    }
}