using System;
using System.Collections.Generic;

namespace AuthLecture2022.Models
{
    public partial class Course
    {
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public byte Credits { get; set; }
        public string Instructor { get; set; } = null!;
    }
}
