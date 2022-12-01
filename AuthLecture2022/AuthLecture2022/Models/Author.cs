using System;
using System.Collections.Generic;

namespace AuthLecture2022.Models
{
    public partial class Author
    {
        public decimal AuthorNum { get; set; }
        public string? AuthorLast { get; set; }
        public string? AuthorFirst { get; set; }
        public string? ImgPath { get; set; }
    }
}
