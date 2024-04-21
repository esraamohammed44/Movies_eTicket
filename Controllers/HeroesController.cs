using eTickets.Models;
using eTickets.Models.ViewModel;
using eTickets.Repository;
using eTickets.Static;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http; 
using System;
using System.IO;

namespace eTickets.Controllers
{
 
    [Authorize(Roles = UserRoles.Admin)]
    public class HeroesController : Controller
    {
        private readonly IHeroRepository _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        // Constructor injection to inject dependencies
        public HeroesController(IHeroRepository context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await _context.GetAllAsync();

            return View(data);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(HeroViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                string uniqueFileName = null;
                if (model.ProfilePictureFile != null && model.ProfilePictureFile.Length > 0)
                {
                    var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(model.ProfilePictureFile.FileName);
                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                     await model.ProfilePictureFile.CopyToAsync(fileStream);
                    }
                }

                var hero = new Hero
                {
                    FullName = model.FullName,
                    Biography = model.Biography,
                    ProfilePictureURL = uniqueFileName != null ? uniqueFileName : null
                };

                await _context.AddAsync(hero);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An error occurred while saving the hero: {ex.Message}");
                return View(model);
            }
        }


     

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var heroDetails = await _context.GetByIdAsync(id);

            if (heroDetails == null) return View("NotFound");
            return View(heroDetails);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var heroDetails = await _context.GetByIdAsync(id);
            if (heroDetails == null) return View("NotFound");
            return View(heroDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Biography")] Hero hero)
        {
            if (!ModelState.IsValid)
            {
                return View(hero);
            }
            await _context.UpdateAsync(id, hero);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var heroDetails = await _context.GetByIdAsync(id);
            if (heroDetails == null) return View("NotFound");
            return View(heroDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var heroDetails = await _context.GetByIdAsync(id);
            if (heroDetails == null) return View("NotFound");

            await _context.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

