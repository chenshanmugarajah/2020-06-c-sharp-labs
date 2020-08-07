using System;
using System.Collections.Generic;

namespace lab_35_library_api.Models
{
    public partial class BoroughLibrarys
    {
        public BoroughLibrarys()
        {
            Books = new List<Books>();
        }

        public int LibraryId { get; set; }
        public string LibraryName { get; set; }

        public virtual List<Books> Books { get; set; }
    }
}
