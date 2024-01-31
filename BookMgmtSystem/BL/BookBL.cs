using DAL;
using Entities;
using Repository;

namespace BL
{
    public class BookBL
    {
        BookDAL bdal= new BookDAL();
        public List<Book> getAllbooks()
        {
            return bdal.getAllBooks();
        }

        public bool AddBooks(Book bk)
        {
            bool res=bdal.AddBooks(bk);
            return res;
        }
    }
}