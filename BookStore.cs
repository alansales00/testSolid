using ConsoleApp1;
using ConsoleApp1.Discounts;

public class BookStore
{
    public List<string> books;

    public BookStore( IDiscount discount)
    {
        books = new List<string>();
    }
}
