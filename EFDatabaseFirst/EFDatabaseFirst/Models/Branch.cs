using System;
using System.Collections.Generic;

namespace EFDatabaseFirst.Models
{
    public partial class Branch
    {
        public decimal BranchNum { get; set; }
        public string? BranchName { get; set; }
        public string? BranchLocation { get; set; }
    }
}
