using System;
using System.Collections.Generic;
using System.Text;

namespace lab_40_entity_code_first.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }

}
