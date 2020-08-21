using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_48_mvc_web_demo.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool CurrentStudent { get; set; }

        public int CollegeId { get; set; }

        public College College { get; set; }

    }
}
