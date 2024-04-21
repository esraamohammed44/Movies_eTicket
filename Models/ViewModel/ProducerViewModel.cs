using System.ComponentModel.DataAnnotations;

namespace eTickets.Models.ViewModel
{
    public class ProducerViewModel
    {

        [Required(ErrorMessage = "Profile Picture is required")]
        [Display(Name = "Profile Picture")]
        public IFormFile ProfilePictureFile { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 characters")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Biography is required")]
        [Display(Name = "Biography")]
        public string Biography { get; set; }
    }

}
