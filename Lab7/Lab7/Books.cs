using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
   public class Books
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }


    public class BookManager
    {
        public static List<Books> GetBooks()
        {
            var books = new List<Books>();

            books.Add(new Books { BookId = 1, Title = "ABC", Author = "abc", CoverImage = "Assets/b2.jpg" });
            books.Add(new Books { BookId = 2, Title = "ABCD", Author = "abcd", CoverImage = "Assets/b2.jpg" });
            books.Add(new Books { BookId = 3, Title = "ABCDE", Author = "abcde", CoverImage = "Assets/b2.jpg" });
        }
    }
}
