﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Student_Management_System.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CreditHours { get; set; }

        [ForeignKey("Department")]
        public int Dept_id { get; set; }
    }
}