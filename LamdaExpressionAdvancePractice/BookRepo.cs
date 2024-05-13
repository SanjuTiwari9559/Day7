using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressionAdvancePractice
{
    public class BookRepo
    {
         public static List<Book> getAllBook(float price)
        {
              List<Book> books = new List<Book>();
            List<Book> optBooks = new List<Book>();
            books.Add(new Book()
            {
                tittle = "Untold Story",
                price = 57.5f

            });
            books.Add(new Book()
            {
                tittle = "My Life My Rule",
                price = 56.24f
            });
            foreach (var book in books)
            {
                if(book.price> price)
                {
                    optBooks.Add(book);
                }
            }
            return optBooks;

        }
         
        
          
    }
}
