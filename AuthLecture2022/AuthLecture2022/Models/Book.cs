using System;
using System.Collections.Generic;

namespace AuthLecture2022.Models
{
    public partial class Book
    {
        public string BookCode { get; set; } = null!;
        public string? Title { get; set; }
        public string? PublisherCode { get; set; }
        public string? Type { get; set; }
        public string? Paperback { get; set; }
        public string? Stuff { get; set; }
    }
}
