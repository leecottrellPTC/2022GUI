using System;
using System.Collections.Generic;

namespace EFDatabaseFirst.Models
{
    public partial class Customer
    {
        public int CustId { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? PayDetails { get; set; }
    }
}
