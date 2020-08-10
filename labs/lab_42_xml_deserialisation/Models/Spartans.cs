using System;
using System.Collections.Generic;

namespace lab_42_xml_deserialisation.Models
{
    public partial class Spartans
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UniversityAttended { get; set; }
        public string CourseTaken { get; set; }
        public string MarkAchieved { get; set; }
    }
}
