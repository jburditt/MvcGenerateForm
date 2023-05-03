using System.ComponentModel.DataAnnotations;

namespace Sandbox
{
    public class FormViewModel
    {
        [Required]
        [MaxLength(7)]
        public string Name { get; set; }

        [Required]
        [Range(0, 10)]
        public int? Code { get; set; }

        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }
    }
}