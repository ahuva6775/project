//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Updates
    {
        public int idUpdats { get; set; }
        public int idPlace { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan time { get; set; }
        public int count { get; set; }
        public int ip { get; set; }
        public string ps { get; set; }
        public int idSale { get; set; }
    
        public virtual Place Place { get; set; }
        public virtual Sale_Time Sale_Time { get; set; }
    }
}
