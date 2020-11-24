using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TennisShop.Models;

namespace TennisShop.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View(CreateArticleList());
        }
        private List<Article> CreateArticleList()
        {
            return new List<Article>()
            {
                new Article(1, "Babolat Pure Strike 2020", 179.99m, "Dominic Thiem's neuer Schläger", new DateTime(2019, 12, 24), Category.Rackets),
                new Article(2, "Babolat Pure Aero 2020", 179.99m, "Rafael Nadal's neuer Schläger", new DateTime(2019, 12, 24), Category.Rackets),
                new Article(3, "Head Speed Elite 2020", 220.99m, "Novak Djokovic's neuer Schläger", new DateTime(2020, 01, 15), Category.Rackets),
                new Article(4, "Babolat Pure Strike Tasche", 99.90m, "Dominic Thiem's neue Tasche", new DateTime(2019, 12, 24), Category.Bags),
                new Article(5, "Dunlop AO Spielball 3er", 3.99m, "Offizieller Spielball der Australien Open 2020", new DateTime(2020, 01, 10), Category.Balls),
                new Article(6, "Wilson RG 2020 4er", 5.99m, "Offizieller Spielball der French Open 2020", new DateTime(2020, 05, 10), Category.Balls),
                new Article(7, "Adidas Heat.Rdy T-Shirt", 59.90m, "Die neue Australien Open Kollektion", new DateTime(2020, 02, 01), Category.Clothes),
                new Article(8, "Adidas Heat.Rdy Hose", 35.90m, "Die neue Australien Open Kollektion", new DateTime(2020, 02, 01), Category.Clothes),

            };
        }
        public IActionResult SendBack()
        {
            return View();
        }
        public IActionResult CreateArticle()
        {
            return View();
        }
    }

}
