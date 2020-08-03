using System;
using System.Collections.Generic;

namespace lab_32_2_tables_hw2.Models
{
    public partial class Cats
    {
        public int CatId { get; set; }
        public string CatName { get; set; }
        public int? CatAge { get; set; }
        public int? BreedId { get; set; }

        public virtual Breeds Breed { get; set; }
    }
}
