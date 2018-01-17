using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameWorkDemo.Models
{
    public class Student
    {
        [Key]
        public string StudentName { get; set; }
        public string StudentClass { get; set; }
        

    }
}