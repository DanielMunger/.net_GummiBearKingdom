using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace GummiBearKingdom.Controllers
{
    public class Products : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            return View();
        }
        [HttpPost] 
        public IActionResult Details()
        {
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string naem, int cost, string country, int picture)
        {
            return RedirectToAction("Index");
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
