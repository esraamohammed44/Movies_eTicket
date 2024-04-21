using eTickets.Base;
using eTickets.Models;

namespace eTickets.Repository
{
    public class CinemaRepository : EntityBaseRepository<Cinema>, ICinemaRepository
    {
        public CinemaRepository(AppDbContext context) : base(context)
        {
        }
    }
}
