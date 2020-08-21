using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_48_mvc_web_demo.Models
{
    public class College
    {
        public College()
        {
            this.Students = new HashSet<Student>();
        }

        public int CollegeId { get; set; }
        public string CollegeName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
