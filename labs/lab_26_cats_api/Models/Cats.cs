using System;
using System.Collections.Generic;

namespace lab_26_cats_api.Models
{
    public partial class Cats
    {
        public int CatId { get; set; }
        public string CatName { get; set; }
        public int? CatAge { get; set; }
        public string CatDescription { get; set; }
    }
}
