using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressionAdvancePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books=BookRepo.getAllBook(50f);
            if (books != null)
            {
                foreach (Book book in books)
                {
                    Console.WriteLine(book.tittle);
                    Console.WriteLine(book.price);
                }
            }
            else
            {
                Console.WriteLine("There is no Data Present");
            }

        }
    }
}
