using System;
using System.Collections.Generic;
using System.Text;

namespace lab_40_entity_code_first.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
