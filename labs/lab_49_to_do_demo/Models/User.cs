using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_49_to_do_demo.Models
{
    public class User
    {
        public User()
        {
            ToDos = new HashSet<ToDo>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<ToDo> ToDos { get; set; }
    }
}
