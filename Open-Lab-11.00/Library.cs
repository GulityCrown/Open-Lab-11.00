using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_11._00
{
    internal class Library
    {
        /// <summary>
        /// list of categories
        /// </summary>
        public static List<string> categoryList = new List<string>() { "detské", "romantické", "náučné", "sci-fi", "dobrodružné" };

        
        private int numberOfBooks;
        private int numberOfStudents;
        private List<string> studentsList = new List<string>();
        private List<string> booksList = new List<string>();
        /// <summary>
        /// getter and setter for studentList
        /// </summary>
        public List<string> StudentsList
        {
            get { return studentsList; }
            set { studentsList = value; }
        }
        /// <summary>
        /// getter and setter for booksList
        /// </summary>
        public List<string> BooksList
        {
            get { return booksList; }
            set { booksList = value; }
        }

        /// <summary>
        /// set/get property for numberOfBooks
        /// </summary>
        public int NumberOfBooks
        {
            get
            {
                return this.numberOfBooks;
            }
            set
            {
                this.numberOfBooks = value;
            }
        }
        /// <summary>
        /// set/get property for numberOfStudents
        /// </summary>
        public int NumberOfStudents
        {
            get
            {
                return this.numberOfStudents;
            }
            set
            {
                this.numberOfStudents = value;
            }
        }
        
        

        /// <summary>
        /// method that reads every field
        /// </summary>
        public override string ToString()
        {
            return String.Format($"number of students: {numberOfStudents}\nnumber of books: " +
                $"{numberOfBooks}\n students: " + string.Join(",", studentsList) + "\nbooks: " + string.Join(",", booksList));
            

        }
    }
}
