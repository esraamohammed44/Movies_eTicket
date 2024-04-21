using System.ComponentModel.DataAnnotations;

namespace eTickets.Models.ViewModel
{
    public class CinemaViewModel
    {

        [Display(Name = " Cinema Logo")]
        public IFormFile Logo { get; set; }

        [Display(Name = " Cinema Name")]
        public string Name { get; set; }

        [Display(Name = " Cinema Description")]

        public string Description { get; set; }
    }
}
