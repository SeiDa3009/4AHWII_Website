using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisShop.Models
{
    public enum Category
    {
        Rackets, Bags, Clothes, Balls, notSpecified
    }
    public class Article
    {
        public int ArticleID { get; set; }
        public string Articlename { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public Category Category { get; set; }


        public Article() : this(0, "", 0.0m, "", null, Category.notSpecified) { }
        public Article(int id, string articlename, decimal price, string description, DateTime? releasedate, Category category)
        {
            this.ArticleID = id;
            this.Articlename = articlename;
            this.Price = price;
            this.Description = description;
            this.ReleaseDate = releasedate;
            this.Category = category;
        }

        public override string ToString()
        {
            return this.ArticleID + " " + this.Articlename + " " + this.Price + " € \n" + this.Description + " \n" + this.ReleaseDate + " \n" + this.Category;
        }
    }
}
