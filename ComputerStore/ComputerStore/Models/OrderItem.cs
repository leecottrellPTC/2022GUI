using System.ComponentModel.DataAnnotations;
namespace ComputerStore.Models
{
    public class OrderItem
    {
        //processor, ram, speed, HD, Email
        [Required(ErrorMessage = "Please pick a CPU")]
        public string Processor { get; set; }
        
        [Required(ErrorMessage = "Please enter RAM between 4 and 32")]
        [Range(8,64, ErrorMessage ="Value for {0} must be between {1} and {2}")]
        public int? RAM { get; set; }
        
        [Required(ErrorMessage = "Please enter speed between 1 and 4")]
        [Range(1, 4, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public double? Speed { get; set; }

        [Required(ErrorMessage = "Please enter HD size between .5 and 4")]
        public double? HDSize { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        public string Email { get; set; }
    }
}
