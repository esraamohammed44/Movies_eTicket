using eTickets.Models;
using eTickets.Models.ViewModel;
using eTickets.Repository;
using eTickets.Static;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class CinemasController : Controller
    {
        private readonly ICinemaRepository _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CinemasController(ICinemaRepository context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;

        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _context.GetAllAsync();
            return View(allCinemas);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Create(CinemaViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                string uniqueFileName = null;
                if (model.Logo != null && model.Logo.Length > 0)
                {
                    var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(model.Logo.FileName);
                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await model.Logo.CopyToAsync(fileStream);
                    }
                }

                var cinema = new Cinema
                {
                    Name = model.Name,
                    Description = model.Description,
                    Logo = uniqueFileName != null ? uniqueFileName : null
                };

                await _context.AddAsync(cinema);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An error occurred while saving the cinema: {ex.Message}");
                return View(model);
            }
        }


        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _context.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var cinemaDetails = await _context.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid) return View(cinema);
            await _context.UpdateAsync(id, cinema);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var cinemaDetails = await _context.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var cinemaDetails = await _context.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");

            await _context.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
