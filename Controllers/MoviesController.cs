using eTickets.Models;
using eTickets.Models.ViewModel;
using eTickets.Repository;
using eTickets.Static;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class MoviesController : Controller
    {
        private readonly IMovieRepository _context;

        public MoviesController(IMovieRepository context)
        {
            _context = context;
        }



        [AllowAnonymous]
        public IActionResult Welcome()
        {
            return View();
        }


        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.GetAllAsync(n => n.Cinema);
            return View(allMovies);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString)
        {
            var allMovies = await _context.GetAllAsync(n => n.Cinema);

            if (!string.IsNullOrEmpty(searchString))
            {
                //var filteredResult = allMovies.Where(n => n.Name.ToLower().Contains(searchString.ToLower()) || n.Description.ToLower().Contains(searchString.ToLower())).ToList();

                var filteredResultNew = allMovies.Where(n => string.Equals(n.Name, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

                return View("Index", filteredResultNew);
            }

            return View("Index", allMovies);
        }

        //GET: Movies/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _context.GetMovieByIdAsync(id);
            return View(movieDetail);
        }

        //GET: Movies/Create
        public async Task<IActionResult> Create()
        {
            var movieDropdownsData = await _context.GetNewMovieDropdownsValues();

            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
            ViewBag.Heroes = new SelectList(movieDropdownsData.Heroes, "Id", "FullName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewMovieVM movie)
        {
            if (!ModelState.IsValid)
            {
                var movieDropdownsData = await _context.GetNewMovieDropdownsValues();

                ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
                ViewBag.Heroes = new SelectList(movieDropdownsData.Heroes, "Id", "FullName");

                return View(movie);
            }

            await _context.AddNewMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }


        //GET: Movies/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var movieDetails = await _context.GetMovieByIdAsync(id);
            if (movieDetails == null) return View("NotFound");

            var response = new NewMovieVM()
            {
                Id = movieDetails.Id,
                Name = movieDetails.Name,
                Description = movieDetails.Description,
                Price = movieDetails.Price,
                StartDate = movieDetails.StartDate,
                EndDate = movieDetails.EndDate,
                ImageURL = movieDetails.ImageURL,
                MovieCategory = movieDetails.MovieCategory,
                CinemaId = movieDetails.CinemaId,
                ProducerId = movieDetails.ProducerId,
                HeroIds = movieDetails.Heroes_Movies.Select(n => n.HeroId).ToList(),
            };

            var movieDropdownsData = await _context.GetNewMovieDropdownsValues();
            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
            ViewBag.Heroes = new SelectList(movieDropdownsData.Heroes, "Id", "FullName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewMovieVM movie)
        {
            if (id != movie.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var movieDropdownsData = await _context.GetNewMovieDropdownsValues();

                ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
                ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
                ViewBag.Heroes = new SelectList(movieDropdownsData.Heroes, "Id", "FullName");

                return View(movie);
            }

            await _context.UpdateMovieAsync(movie);
            return RedirectToAction(nameof(Index));
        }
        //GET: Movies/AboutUs
        [AllowAnonymous]
      
            public IActionResult AboutUs()
            {
                var model = new AboutUs
                {
                    Title = "About Us",
                    Description = "Welcome to eTickets, your premier destination for hassle-free movie ticket booking!",
                    Mission = "Our mission is to make movie ticket booking easy, convenient, and enjoyable for everyone.",
                    Vision = "Our vision is to become the go-to platform for all movie enthusiasts, providing the best viewing experiences.",
                    CompanyAddress = "123 Movie Street, Assuit",
                    ContactEmail = "movieseticket@gmail.com"
                };

                return View(model);
            }



        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var movieDetail = await _context.GetMovieByIdAsync(id);
            if (movieDetail == null) return View("NotFound");

            // Retrieve additional data from your data context or other sources
            var cinemaId = movieDetail.CinemaId;
            var producerId = movieDetail.ProducerId;

            // Create a NewMovieVM object and populate its properties
            var viewModel = new NewMovieVM
            {
                Id = movieDetail.Id,
                Name = movieDetail.Name,
                Description = movieDetail.Description,
                Price = movieDetail.Price,
                ImageURL = movieDetail.ImageURL,
                StartDate = movieDetail.StartDate,
                EndDate = movieDetail.EndDate,
                MovieCategory = movieDetail.MovieCategory,
                CinemaId = cinemaId,
                ProducerId = producerId,
                // Populate other properties as needed
            };

            return View(viewModel);
        }


        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var MovieDetails = await _context.GetByIdAsync(id);
            if (MovieDetails == null) return View("NotFound");

            await _context.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }



        [AllowAnonymous]
        public async Task<IActionResult> PrivacyPolicy()
        {
            var privacyPolicyContent = await _context.GetPrivacyPolicyContentAsync();
            var privacyPolicy = new PrivacyPolicy
            {
                Content = privacyPolicyContent
            };
            return View(privacyPolicy);
        }
       
    }
}
