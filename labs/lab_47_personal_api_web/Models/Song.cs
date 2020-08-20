using System;
using System.Collections.Generic;
using System.Text;

namespace lab_47_personal_api_web.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string SongName { get; set; }
        public string SongArtist { get; set; }
        public int SongSales { get; set; }

        public int? RecordLabelId { get; set; }
        public virtual RecordLabel RecordLabel { get; set; }
    }
}
