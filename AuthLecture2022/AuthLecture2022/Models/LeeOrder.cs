using System;
using System.Collections.Generic;

namespace AuthLecture2022.Models
{
    public partial class LeeOrder
    {
        public LeeOrder()
        {
            LeeOrderDetails = new HashSet<LeeOrderDetail>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int EmpId { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ICollection<LeeOrderDetail> LeeOrderDetails { get; set; }
    }
}
