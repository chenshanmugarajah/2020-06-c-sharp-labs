using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_49_to_do_demo.Models
{
    public class DisplayToDoWithUserName
    {
        public int id { get; set; }
        public string item { get; set; }
        public string username { get; set; }

        public string categoryName { get; set; }
    }
}
