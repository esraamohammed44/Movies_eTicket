using Microsoft.AspNetCore.Mvc;
using eTickets.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
using eTickets.Models;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ProfileController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound();
            }

            var profileViewModel = new RegisterVM
            {
                FullName = user.FullName,
                EmailAddress = user.Email,
                // Include Password and ConfirmPassword fields
                Password = string.Empty,
                ConfirmPassword = string.Empty
            };

            return View(profileViewModel);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            var profileViewModel = new RegisterVM(); // Create an empty RegisterVM object
            return View(profileViewModel);
        }

        // POST: Profile/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return NotFound();
                }

                if (!string.IsNullOrEmpty(model.FullName) && user.FullName != model.FullName)
                {
                    user.FullName = model.FullName;
                }
                if (!string.IsNullOrEmpty(model.EmailAddress) && user.Email != model.EmailAddress)
                {
                    user.Email = model.EmailAddress;
                }
                if (!string.IsNullOrEmpty(model.Password))
                {
                    var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                    await _userManager.ResetPasswordAsync(user, token, model.Password);
                }

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return View(model);
        }

    }
}
