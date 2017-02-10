using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GummiBearKingdom.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using System.IO;


namespace GummiBearKingdom.Controllers
{
    public class Products : Controller
    {
        private GummiBearKingdomContext db = new GummiBearKingdomContext();
        public IActionResult Index()
        {
            return View(db.Products.ToList());
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
        public IActionResult Create(string name, int cost, string country, IFormFile picture)
        {
            byte[] pictureArray = new byte[0];
            if(picture.Length > 0)
            {
                using (var fileStream = picture.OpenReadStream())
                using (var ms = new MemoryStream())
                {
                    fileStream.CopyTo(ms);
                    pictureArray = ms.ToArray();
                }
            }
            Product newProduct = new Product(name, cost, country, pictureArray);
            db.Products.Add(newProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
