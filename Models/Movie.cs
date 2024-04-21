using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using eTickets.Base;

namespace eTickets.Models
{
    public class Movie : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Movie Name")]
        public string Name { get; set; }


        [Display(Name = "Movie Description")]
        public string Description { get; set; }


        [Display(Name = "Movie Price")]
        public double Price { get; set; }

        [Display(Name = "Movie ImageURL")]
        public string ImageURL { get; set; }

        [Display(Name = "Movie StartDate")]
        public DateTime StartDate { get; set; }


        [Display(Name = "Movie StartDate")]
        public DateTime EndDate { get; set; }
        public  MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Hero_Movie>? Heroes_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
