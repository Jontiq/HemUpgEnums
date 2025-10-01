using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemUpgEnums
{
    internal class Book
    {
        //props
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        //constructor
        public Book (string Title, string Author, int Pages)
        {
            this.Title = Title;
            this.Author = Author;
            this.Pages = Pages;
        }

        //methods
        public string GetBookInfo()
        {
            return $"Title: {Title} - Author: {Author} - Pages: {Pages}.";
        }
    }
}
