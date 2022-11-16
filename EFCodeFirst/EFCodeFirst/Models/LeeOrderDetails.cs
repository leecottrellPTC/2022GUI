using System.ComponentModel.DataAnnotations;

namespace EFCodeFirst.Models
{
    public class LeeOrderDetails
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderID { get; set; }
        public int ProdID { get; set; }
        public int Quantity { get; set; }
        public LeeOrder Order { get; set; }

    }
}
