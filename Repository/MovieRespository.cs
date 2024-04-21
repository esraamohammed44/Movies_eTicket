using eTickets.Base;
using eTickets.Models.ViewModel;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;



namespace eTickets.Repository
{
    public class MovieRespository : EntityBaseRepository<Movie>, IMovieRepository
    {
        private readonly AppDbContext _context;
        public MovieRespository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task DeleteMovieAsync(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                await _context.SaveChangesAsync();
            }
        }
        public async Task AddNewMovieAsync(NewMovieVM data)
        {
            var newMovie = new Movie()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageURL = data.ImageURL,
                CinemaId = data.CinemaId,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                MovieCategory = data.MovieCategory,
                ProducerId = data.ProducerId
            };
            await _context.Movies.AddAsync(newMovie);
            await _context.SaveChangesAsync();

            //Add Movie Actors
            foreach (var heroId in data.HeroIds)
            {
                var newHeroMovie = new Hero_Movie()
                {
                    MovieId = newMovie.Id,
                    HeroId = heroId
                };
                await _context.Heroes_Movies.AddAsync(newHeroMovie);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = await _context.Movies
                .Include(c => c.Cinema)
                .Include(p => p.Producer)
                .Include(am => am.Heroes_Movies).ThenInclude(a => a.Hero)
                .FirstOrDefaultAsync(n => n.Id == id);

            return movieDetails;
        }

        public async Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues()
        {
            var response = new NewMovieDropdownsVM()
            {
                Heroes = await _context.Heroes.OrderBy(n => n.FullName).ToListAsync(),
                Cinemas = await _context.Cinemas.OrderBy(n => n.Name).ToListAsync(),
                Producers = await _context.Producers.OrderBy(n => n.FullName).ToListAsync()
            };

            return response;
        }

        public async Task UpdateMovieAsync(NewMovieVM data)
        {
            var dbMovie = await _context.Movies.FirstOrDefaultAsync(n => n.Id == data.Id);

            if (dbMovie != null)
            {
                dbMovie.Name = data.Name;
                dbMovie.Description = data.Description;
                dbMovie.Price = data.Price;
                dbMovie.ImageURL = data.ImageURL;
                dbMovie.CinemaId = data.CinemaId;
                dbMovie.StartDate = data.StartDate;
                dbMovie.EndDate = data.EndDate;
                dbMovie.MovieCategory = data.MovieCategory;
                dbMovie.ProducerId = data.ProducerId;
                await _context.SaveChangesAsync();
            }

            //Remove existing Heros
            var existingHerosDb = _context.Heroes_Movies.Where(n => n.MovieId == data.Id).ToList();
            _context.Heroes_Movies.RemoveRange(existingHerosDb);
            await _context.SaveChangesAsync();

            //Add Movie Actors
            foreach (var heroId in data.HeroIds)
            {
                var newHeroMovie = new Hero_Movie()
                {
                    MovieId = data.Id,
                    HeroId = heroId
                };
                await _context.Heroes_Movies.AddAsync(newHeroMovie);
            }
            await _context.SaveChangesAsync();
        }
        // Method to count total movies
        public async Task<int> CountAsync()
        {
            return await _context.Movies.CountAsync();
        }

        public async Task<int> GetActiveMoviesCountAsync()
        {
            return await _context.Movies.CountAsync(m => m.StartDate <= DateTime.Now && m.EndDate >= DateTime.Now);
        }

        public async Task<List<Movie>> GetUpcomingMoviesAsync()
        {
            return await _context.Movies.Where(m => m.StartDate > DateTime.Now).ToListAsync();
        }
        public async Task<string> GetPrivacyPolicyContentAsync()
        {
            var privacyPolicy = await _context.PrivacyPolicies.FirstOrDefaultAsync();
            return privacyPolicy?.Content;
        }

    }
}