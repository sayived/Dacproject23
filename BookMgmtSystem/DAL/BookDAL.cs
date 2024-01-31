using Entities;
using Repository;

namespace DAL
{
    public class BookDAL
    {
        public List<Book> getAllBooks()
        {
            return BookRepository.blist;
        }

        public bool AddBooks(Book bk)
        {
            BookRepository.blist.Add(bk);
            return true;
        }

    }
}