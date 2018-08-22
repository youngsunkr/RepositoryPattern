using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Models.DAL
{
    public class BookRepository : IBookRepository
    {

        DataContext _context;

        public BookRepository(DataContext context)
        {
            this._context = context;
        }

        public void DeleteContent(int bookID)
        {
            Book book = _context.Book.Find(bookID);
            _context.Book.Remove(book);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetConetnt()
        {
            return _context.Book.ToList();
        }

        public Book GetContentByID(int bookID)
        {
            return _context.Book.Find(bookID);
        }

        public void InsertContent(Book book)
        {
            _context.Book.Add(book);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateContent(Book book)
        {
            _context.Entry(book).State = System.Data.Entity.EntityState.Modified; 
        }
    }
}