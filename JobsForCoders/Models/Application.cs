//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobsForCoders.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Application
    {
        public int ApplicationID { get; set; }
        public int JobID { get; set; }
        public int JobSeekerID { get; set; }
        public System.DateTime Application_Date { get; set; }
    
        public virtual JobPosting JobPosting { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }
    }
}