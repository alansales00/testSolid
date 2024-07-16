using ConsoleApp1.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleApp1
{
    internal class BookStoreService : IBookStoreService
    {
        BookStore store { get; set; }
        public BookStoreService(BookStore store) 
        {
            this.store = store;
        }

        public void AddBook(string book)
        {

            store.books.Add(book);
        }

        public void DeleteBook(string book)
        {
            store.books.Remove(book);
        }

        public void PrintBooks()
        {
            foreach (var book in store.books)
            {
                Console.WriteLine(book);
            }
        }

    }
}
