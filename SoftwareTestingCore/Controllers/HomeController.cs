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
            CarViewModel vm = new CarViewModel();

            if (id == 2) {
                // success
                vm.Notification = 2;
                return View(vm);
            }
            
            return View(vm);
        }

        [HttpPost]
        public IActionResult Index(CarViewModel vm) {

            string brand = vm.Car.Brand;
            string type = vm.Car.Type;
            int price = vm.Car.PriceRange;
            string location = vm.Car.Location;

            if (!ModelState.IsValid) {
                vm.Notification = 1;
                return View(vm);
            }


            if (brand.Equals("Tesla") && type != "Electric") {
                ModelState.AddModelError("Car.Type", "Tesla only produces electric vehicles.");
                vm.Notification = 1;
            }


            /*
             * London
             */

            if (location.Equals("London"))
            {
                if (brand.Equals("Audi") && type.Equals("Electric"))
                {
                    ModelState.AddModelError("Car.Type", brand + " does not offer electric vehicles in the U.K.");
                    vm.Notification = 1;
                }
            }


            /*
             * China
             */

            if (location.Equals("China")) {

                // Can't have diesel in China
                if (type.Equals("Diesel")) {
                    ModelState.AddModelError("Car.Type", brand + " does not offer diesel powered cars in China.");
                    vm.Notification = 1;
                }

                if (price <= 15000) {
                    if (!brand.Equals("Audi") && !brand.Equals("Tesla"))
                    {
                        if (type.Equals("Diesel"))
                        {
                            ModelState.AddModelError("Car.Type", brand + " does not offer diesel powered cars in China.");
                        }
                        else if (type.Equals("Electric"))
                        {
                            ModelState.AddModelError("Car.Type", brand + " does not offer electric powered cars in China.");
                        }
                        else
                        {
                            ModelState.AddModelError("Car.Type", "No " + brand + " found in China at this price range.");
                        }

                        vm.Notification = 1;
                    }
                    else if (brand.Equals("Audi") && type.Equals("Electric")) {
                        ModelState.AddModelError("Car.Type", brand + " does not offer electric powered cars in China.");
                        vm.Notification = 1;
                    }

                  
                }

            }


            /*
             * Miami
             */

            if (location.Equals("Miami")) {
                if (price <= 15000) {
                    if (type.Equals("Electric"))
                    {
                        ModelState.AddModelError("Car.Type", "No electric " + brand + " found in Miami at this price range.");
                        vm.Notification = 1;
                    }
                    else {
                        ModelState.AddModelError("Car.Type", "No " + brand + " found in Miami at this price range.");
                        vm.Notification = 1;
                    }
                }
                
            }


            /*
             * LA
             */

            if (location.Equals("LA")) {
                if (price <= 15000)
                {
                    if (type.Equals("Electric"))
                    {
                        ModelState.AddModelError("Car.Type", "No electric " + brand + " found in LA at this price range.");
                    }
                    else
                    {
                        ModelState.AddModelError("Car.Type", "No " + brand + " found in LA at this price range.");
                    }
                }
                vm.Notification = 1;
            }







            if (vm.Notification == 1) {
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
