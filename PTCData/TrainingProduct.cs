using System;
using System.ComponentModel.DataAnnotations;

namespace PTCData
{
    public class TrainingProduct
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product name must be filled in.")]
        [Display(Description = "Product Name")]
        [StringLength(150, MinimumLength = 4, ErrorMessage = "Product name must be greater than {2} and less than {1}")]
        public string ProductName { get; set; }

        [Range(typeof(DateTime), "1/1/2001", "12/31/2020", ErrorMessage = "{0} must be between {1} and {2}")]
        [Display(Description = "Introduction Date")]
        public DateTime IntroductionDate { get; set; }

        [Required(ErrorMessage = "Url must be fill in.")]
        [Display(Description = "Url")]
        [StringLength(2000, MinimumLength = 5, ErrorMessage = "URL must be greater than {2} characters")]
        public string Url { get; set; }

        [Range(1, 9999, ErrorMessage = "{0} must be between {1} and {2}")]
        public decimal Price { get; set; }
    }
}
