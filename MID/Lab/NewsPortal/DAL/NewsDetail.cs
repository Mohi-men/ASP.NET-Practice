//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class NewsDetail
    {
        public NewsDetail()
        {
            this.Comments = new HashSet<Comment>();
            this.Reactions = new HashSet<Reaction>();
        }
    
        public int id { get; set; }
        public string Info { get; set; }
        public int PostedBy { get; set; }
        public string PostDate { get; set; }
        public string NewsCat { get; set; }
    
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Reaction> Reactions { get; set; }
        public virtual NewsCategory NewsCategory { get; set; }
    }
}
