using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IBookStoreService
    {
        void AddBook(String book);
        void DeleteBook(String book);
        public void PrintBooks();
    }
}
