using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LibraryClass
{
    public class Library
    {
        List<Book> books;
        public string Name { get; set; }
        public int numBooks { get; set; }
        public Book displayBook { get; set; }
        public List<Book> GetBooks()
        {
            return books;
        }
        public void setDisplay(Book b)
        {
            displayBook = b;
        }
        public void addBook(Book b)
        {
            this.numBooks += b.count;
            this.books.Add(b);
        }
        public Library(string name)
        {
            this.Name = name;
            this.numBooks = 0;
            this.displayBook = null;
            this.books = new List<Book>();
            
        }
    }
    public class Book
    {
        public string Name { get; set; }
        public int ISBN { get; set; }
        public int count { get; set; }
        
        public Bitmap image { get; set; }

        public Book(string name, int isbn, int count)
        {
            this.Name = name; this.ISBN = isbn; this.count = count;
        }
    }
}
