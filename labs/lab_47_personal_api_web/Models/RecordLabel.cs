using System;
using System.Collections.Generic;
using System.Text;

namespace lab_47_personal_api_web.Models
{
    public class RecordLabel
    {
        public int RecordLabelId { get; set; }
        public string RecordLabelName { get; set; }
        public DateTime FoundedDate { get; set; }

        public virtual ICollection<Song> Songs { get; set; }

    }
}
