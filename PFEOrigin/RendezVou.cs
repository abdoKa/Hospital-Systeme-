//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PFEOrigin
{
    using System;
    using System.Collections.Generic;
    
    public partial class RendezVou
    {
        public int idRV { get; set; }
        public Nullable<System.DateTime> RVdate { get; set; }
        public Nullable<System.TimeSpan> RVTime { get; set; }
        public Nullable<int> id { get; set; }
        public Nullable<int> id_Doc { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
