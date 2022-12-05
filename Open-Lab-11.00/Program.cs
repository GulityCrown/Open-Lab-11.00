using Open_Lab_11._00;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_11._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book dejepis = new Book("Dejepis", 356);
            Book zakladyElektrotechniky = new Book("základy elektrotechniky", 125);
            Book slovencina = new Book("Slovenčina", 134);
            Book fyzika = new Book("Fyzika", 124);
            Library schoolLibrary = new Library();

            schoolLibrary.StudentsList.Add("John");
            schoolLibrary.StudentsList.Add("Poul");
            schoolLibrary.BooksList.Add("dejepis");
            schoolLibrary.BooksList.Add("základy elektrotechniky");
            schoolLibrary.BooksList.Add("Slovenčina");
            schoolLibrary.BooksList.Add("fyzika");
            Console.WriteLine(schoolLibrary.ToString());
            



            
        }
    }
}

