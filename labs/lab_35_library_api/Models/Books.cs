using System;
using System.Collections.Generic;

namespace lab_35_library_api.Models
{
    public partial class Books
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public int? LibraryId { get; set; }

        public virtual BoroughLibrarys Library { get; set; }
    }
}
