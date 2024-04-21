using eTickets.Base;
using eTickets.Models;

namespace eTickets.Repository
{
    public class ProducerRepository : EntityBaseRepository<Producer>, IProducerRepository
    {
        public ProducerRepository(AppDbContext context) : base(context)
        {
        }
    }
}
