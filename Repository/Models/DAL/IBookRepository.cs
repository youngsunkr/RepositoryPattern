using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models.DAL
{
    public interface IBookRepository : IDisposable
    {
        IEnumerable<Book> GetBooks();

        Book GetBookByID(int bookID);

        void InsertBook(Book book);

        void DeleteBook(int bookID);

        void UpdateBook(Book book);

        void Save();
    }
}
