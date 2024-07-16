using ConsoleApp1.Discounts;
using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookStore store = new BookStore(new BookDayDiscount());
            BookStoreService service = new BookStoreService(store);
            service.AddBook("Piranesi");
            service.AddBook("A casa torta");
            service.PrintBooks();
            
        }
    }
}
