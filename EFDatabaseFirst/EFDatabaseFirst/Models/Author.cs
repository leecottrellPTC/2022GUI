using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDatabaseFirst.Models
{
    public partial class Author
    {
        public decimal AuthorNum { get; set; }
        [Display(Name ="Last Name")]
        public string? AuthorLast { get; set; }
        [Display(Name = "First Name")]
        public string? AuthorFirst { get; set; }
        [Display(Name = "Picture URL")]
        public string? ImgPath { get; set; }
    }
}
