using Open_Lab_11._00;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_11._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book LOTR2 = new Book();

            /*LOTR.Title = "Lord Of The Rings";
            LOTR.Author = "J.J.R.Tolkien";
            LOTR.Category = "epic high-fantasy novel";
            LOTR.Pages = 1172;
            LOTR.RelaseDate = "29th July 1954";*/
            LOTR2.Vypis();
            Book LOTR3 = new Book("Lord of the Rings 3", 512);
            LOTR3.Vypis();
            Book HOBBIT = new Book("Hobbit", 310, "juvenile fantasy", "J.R.R.Tolkien", 1937);

            HOBBIT.Category = Book.categoryList[4];
            HOBBIT.Vypis();

            Console.WriteLine("LOTR3 title is: " + HOBBIT.Pages);
        }
    }
}

