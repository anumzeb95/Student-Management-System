using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Student_Management_System.Models
{
    public class RegistrationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Password { get; set; }
        public string Cnic { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }



        [ForeignKey("Department")]
        public int Dept_id { get; set; }

        public Nullable<int> course_id { get; set; }

        public virtual CourseModel course { get; set; }


        public Nullable<int> dept_id { get; set; }
       
        public virtual DepartmentModel dept { get; set; }
        
    }
}