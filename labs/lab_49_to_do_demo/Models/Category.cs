using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_49_to_do_demo.Models
{
    public class Category
    {
        public Category()
        {
            Categories = new HashSet<Category>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
