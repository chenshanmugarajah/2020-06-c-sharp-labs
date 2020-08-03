using System;
using System.Collections.Generic;

namespace lab_32_2_tables_hw2.Models
{
    public partial class Breeds
    {
        public Breeds()
        {
            Cats = new HashSet<Cats>();
        }

        public int BreedId { get; set; }
        public string BreedName { get; set; }

        public virtual ICollection<Cats> Cats { get; set; }
    }
}
