using System.ComponentModel.DataAnnotations;
namespace EFCodeFirst.Models
{
    public class LeeOrder
    {
        [Key]
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmpID { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
