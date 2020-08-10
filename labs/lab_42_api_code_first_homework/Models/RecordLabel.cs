using System;
using System.Collections.Generic;
using System.Text;

namespace lab_42_api_code_first_homework.Models
{
    public class RecordLabel
    {
        public int RecordLabelId { get; set; }
        public string RecordLabelName { get; set; }
        public DateTime FoundedDate { get; set; }

        public virtual ICollection<Song> Songs { get; set; }

    }
}
