//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Following
    {
        public long Id { get; set; }
        public long FollowerId { get; set; }
        public bool isActive { get; set; }
        public long UserId { get; set; }
    
        public virtual Person Person { get; set; }
    }
}