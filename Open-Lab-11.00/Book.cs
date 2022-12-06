using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_11._00
{
    internal class Book
    {
        /// <summary>
        /// list of categories
        /// </summary>
        public static List<string> categoryList = new List<string>() { "detské", "romantické", "náučné", "sci-fi", "dobrodružné" };

        private string title;
        private string category;
        private string author;
        private int relaseDate;
        private int pages;
        /// <summary>
        /// set/get property for title
        /// </summary>
        public string Title { get { return title; } set { title = value; } }
        /// <summary>
        /// set/get property for category
        /// </summary>
        public string Category
        {
            set { category = value; }
        }
        /// <summary>
        /// set/get property for author
        /// </summary>
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        /// <summary>
        /// set/get property for relaseDate
        /// </summary>
        public int RelaseDate
        {
            get => relaseDate;
            set
            {
                if ((value >= 2021) || (value <= 1450))
                {
                    relaseDate = -1;
                }
                else
                {
                    relaseDate = value;
                }
            }

        }
        /// <summary>
        /// set/get property for pages
        /// </summary>
        public int Pages
        {
            get { return pages; }
            set
            {
                pages = value;
            }
        }
        /// <summary>
        /// non paramethrized constructor that sets every field to -1
        /// </summary>
        public Book()
        {
            title = "-1";
            category = "-1";
            author = "-1";
            relaseDate = -1;
            pages = -1;
        }
        /// <summary>
        /// parametherized constructor that sets title and pages(constructor overloading)
        /// </summary>
        public Book(string xTitle, int xPages)
        {
            this.title = xTitle;
            this.category = "-1";
            this.author = "-1";
            this.relaseDate = -1;
            this.pages = xPages;
        }
        /// <summary>
        /// parametherized constructor that sets every field(constructor overloading)
        /// </summary>
        public Book(string xTitle, int xPages, string xCategory, string xAuthor, int xRelaseDate)
        {
            title = xTitle;
            category = xCategory;
            author = xAuthor;
            relaseDate = xRelaseDate;
            pages = xPages;
        }


        /// <summary>
        /// method that reads every field
        /// </summary>
        public override string ToString()
        {
            return String.Format($"Title: {title}\nAuthor: {author}\ncategory: {category}\nrelase Date: {relaseDate}\npages: {pages}");

        }
    }
}
