using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Hero_Movie
    {
      
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int HeroId { get; set; }
        public Hero Hero { get; set; }
    }
}
