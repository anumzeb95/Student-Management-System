using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_Management_System.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int Password { get; set; }
    }
}