using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models.DAL
{
    public interface IBookRepository : IDisposable
    {
        IEnumerable<Book> GetConetnt();

        Book GetContentByID(int bookID);

        void InsertContent(Book book);

        void DeleteContent(int bookID);

        void UpdateContent(Book book);

        void Save();
    }
}
