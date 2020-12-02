using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyOwnWebsite.Models;
using System.IO;

namespace MyOwnWebsite.Controllers
{
    public class NewsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new News());
        }


        [HttpPost]
        public IActionResult CreateNewNews(News a)
        {
            if (a == null)
            {
                return RedirectToAction("createNewNews");
            }

            ControllInputNews(a);

            if (ModelState.IsValid)
        {
                return RedirectToAction("index", "home");
            }

            return View(a);
        }
        private void ControllInputNews(News a)
        {
            if (a == null)
            {
                return;
            }

            if (a.Header == null)
            {
                a.Header = "";
            }

            else
            {
                a.Header = a.Header;
            }

            //Länge
            if (a.Header.Length < 2)
            {
                ModelState.AddModelError(nameof(News.Header), "Überschrift muss länger sein!");
            }
            if (a.Content == null)
            {
                ModelState.AddModelError(nameof(News.Content), "Muss ausgefühlt sein!");
            }
            if (a.ReleaseDate > DateTime.Now)
            {
                ModelState.AddModelError(nameof(News.ReleaseDate), "Das Datum ist noch nit vorgekommen!");
            }
            if (a.Category.Equals(Category.notSpecified))
            {
                ModelState.AddModelError(nameof(News.Category), "Eine Kategorie auswählen!");
            }
        }
    }
}
