//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Student_Management_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class class_details
    {
        public int Std_id { get; set; }
        public int Course_id { get; set; }
        public int GPA { get; set; }
    
        public virtual course_info course_info { get; set; }
        public virtual std_info std_info { get; set; }
    }
}
