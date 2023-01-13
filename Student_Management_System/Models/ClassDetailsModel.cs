using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Student_Management_System.Models
{
    public class ClassDetailsModel
    {
        [ForeignKey("Student")]
        public int Std_Id { get; set; }

        [ForeignKey("Course")]
        public int Course_Id { get; set; }
        public int GPA { get; set; }
    }
}