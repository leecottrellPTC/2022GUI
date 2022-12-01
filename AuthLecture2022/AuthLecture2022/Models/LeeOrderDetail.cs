using System;
using System.Collections.Generic;

namespace AuthLecture2022.Models
{
    public partial class LeeOrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProdId { get; set; }
        public int Quantity { get; set; }

        public virtual LeeOrder Order { get; set; } = null!;
    }
}
