﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Student_Management_System.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public int password = 123;

        public string Phonenumber { get; set; }
        public string Address { get; set; }

        [ForeignKey("Department")]
        public int Dept_id { get; set; }
    }
}