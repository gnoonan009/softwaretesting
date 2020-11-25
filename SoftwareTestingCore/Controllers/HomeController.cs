using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SoftwareTestingCore.Models;

namespace SoftwareTestingCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? id = 0)
        {
            UserViewModel vm = new UserViewModel();

            if (id == 2) {
                // success
                vm.notification = 2;
                return View(vm);
            }
            
            return View(vm);
        }

        [HttpPost]
        public IActionResult Index(UserViewModel vm) {

            if (!ModelState.IsValid) {
                vm.notification = 1;
            }

            /*
             * Although there's a quicker way to do this with DataAnnotations and model validation,
             * We check each input field individually for the purposes of software testing
             */

            /*
             * First Name
             */
            if (string.IsNullOrEmpty(vm.user.FirstName) || vm.user.FirstName.Length == 0 || vm.user.FirstName.Length > 15) {
                ModelState.AddModelError("user.FirstName", "First Name cannot be empty or more than 15 characters.");
                vm.notification = 1;
            }
            if (string.IsNullOrEmpty(vm.user.FirstName) || !Regex.IsMatch(vm.user.FirstName, @"^[a-zA-Z]+$"))
            {
                ModelState.AddModelError("user.FirstName", "First Name can only contain characters.");
                vm.notification = 1;
            }

            /*
             * Last Name
             */
            if (string.IsNullOrEmpty(vm.user.LastName) || vm.user.LastName.Length == 0 || vm.user.LastName.Length > 15)
            {
                ModelState.AddModelError("user.LastName", "Last Name cannot be empty or more than 15 characters.");
                vm.notification = 1;
            }
            if (string.IsNullOrEmpty(vm.user.LastName) || !Regex.IsMatch(vm.user.LastName, @"^[a-zA-Z]+$"))
            {
                ModelState.AddModelError("user.LastName", "Last Name can only contain characters.");
                vm.notification = 1;
            }

            /*
             * Phone
             */
            if (string.IsNullOrEmpty(vm.user.Phone) || vm.user.Phone.Length != 10)
            {
                ModelState.AddModelError("user.Phone", "Phone number must be 10 digits.");
                vm.notification = 1;
            }
            if (string.IsNullOrEmpty(vm.user.Phone) || !(vm.user.Phone.All(char.IsDigit)))
            {
                ModelState.AddModelError("user.Phone", "The Phone field is not a valid phone number.");
                vm.notification = 1;
            }

            /*
             * Email
             */
            if (string.IsNullOrEmpty(vm.user.Email) || vm.user.Email.Length > 30)
            {
                ModelState.AddModelError("user.Email", "Email cannot be empty or more than 30 characters.");
                vm.notification = 1;
            }
            if (string.IsNullOrEmpty(vm.user.Email) || !Regex.IsMatch(vm.user.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                ModelState.AddModelError("user.Email", "Email is in invalid format. ");
                vm.notification = 1;
            }

            /*
             * Password
             */
            if (string.IsNullOrEmpty(vm.user.Password) || vm.user.Password.Length > 30)
            {
                ModelState.AddModelError("user.Password", "Password cannot be empty or more than 30 characters.");
                vm.notification = 1;
            }
            if (string.IsNullOrEmpty(vm.user.Password) || (vm.user.Password.All(char.IsDigit)))
            {
                ModelState.AddModelError("user.Password", "Password must contain at least 1 digit and 1 character.");
                vm.notification = 1;
            }
            if (string.IsNullOrEmpty(vm.user.Password) || (vm.user.Password.All(char.IsLetter)))
            {
                ModelState.AddModelError("user.Password", "Password must contain at least 1 digit and 1 character.");
                vm.notification = 1;
            }
            if (string.IsNullOrEmpty(vm.user.Password) || string.IsNullOrEmpty(vm.user.PasswordConfirm) || !vm.user.Password.Equals(vm.user.PasswordConfirm))
            {
                ModelState.AddModelError("user.Password", "Password and confirmed password do not match.");
                ModelState.AddModelError("user.PasswordConfirm", "Password and confirmed password do not match.");
                vm.notification = 1;
            }
            if (string.IsNullOrEmpty(vm.user.PasswordConfirm) || (vm.user.PasswordConfirm.All(char.IsDigit)))
            {
                ModelState.AddModelError("user.PasswordConfirm", "Password Confirm must contain at least 1 digit and 1 character.");
                vm.notification = 1;
            }
            if (string.IsNullOrEmpty(vm.user.PasswordConfirm) || (vm.user.PasswordConfirm.All(char.IsLetter)))
            {
                ModelState.AddModelError("user.PasswordConfirm", "Password Confirm must contain at least 1 digit and 1 character.");
                vm.notification = 1;
            }

            if (vm.notification == 1) {
                return View(vm);
            }

            return RedirectToAction("Index", "Home", new { id = 2 });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




    }
}
