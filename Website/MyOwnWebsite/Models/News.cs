using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnWebsite.Models
{
    public enum Category
    {
        Global, Local, Weather, Sport, Deathnotice, notSpecified
    }
    public class News
    {
        public int ArticleNr { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public Category Category { get; set; }

        public News() : this(0, "", "", null, Category.notSpecified) { }
        public News(int nr, string artheader, string content, DateTime? releaseDate, Category category)
        {
            this.ArticleNr = nr;
            this.Header = artheader;
            this.Content = content;
            this.ReleaseDate = releaseDate;
            this.Category = category;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
