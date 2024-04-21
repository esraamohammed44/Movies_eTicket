using eTickets.Base;
using eTickets.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace eTickets.Repository
{
    public class HeroRepository : EntityBaseRepository<Hero>,IHeroRepository
    {
        public HeroRepository(AppDbContext context) : base(context) { }
    }
}
