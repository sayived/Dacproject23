using Entities;

namespace Repository
{
    public static class BookRepository
    {
        public static List<Book> blist = new List<Book>()
        {
            new Book{Id=1,Title="JAva",Author="scott",Booktype='E',price=234.5f,Publication="Nirali" },
            new Book{Id=1,Title="JAva1",Author="scott",Booktype='E',price=234.5f,Publication="Nirali" },
            new Book{Id=1,Title="JAva2",Author="scott",Booktype='E',price=234.5f,Publication="Nirali" },
            new Book{Id=1,Title="JAva3",Author="scott",Booktype='E',price=234.5f,Publication="Nirali" },

        };
    }
}