//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlApar.az.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ElanProfileFavour
    {
        public int Id { get; set; }
        public Nullable<int> ElanId { get; set; }
        public Nullable<int> ProfileId { get; set; }
    
        public virtual Ad Ad { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
