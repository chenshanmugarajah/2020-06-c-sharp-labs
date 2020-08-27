using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lab_48_mvc_web_demo.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        
        [Display(Name = "Is Student Current?")]
        public bool CurrentStudent { get; set; }

        public int CollegeId { get; set; }

        public College College { get; set; }

    }
}
