using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormTagHelpers2.Models;

namespace FormTagHelpers2.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;

        public HomeController(IRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            return View(repository.Fruits);
        }

        public IActionResult AddFruit()
        {
            return View();
        }
        //this is working after reboot of file
        [HttpPost]
        [ValidateAntiForgeryTokenAttribute]
        public IActionResult AddFruit(Fruit fruit)
        {
            repository.AddFruit(fruit);
            return RedirectToAction("Index");
        }

      //model binding example- shows first fruit in form in addfruit page

        public IActionResult EditFruit()
        {
            return View("AddFruit", repository.Fruits.First());
        }


    }
}
