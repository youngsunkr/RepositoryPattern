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

        public void DeleteBook(int bookID)
        {
            Book book = _context.Book.Find(bookID);
            _context.Book.Remove(book);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Book.ToList();
        }

        public Book GetBookByID(int bookID)
        {
            return _context.Book.Find(bookID);
        }

        public void InsertBook(Book book)
        {
            _context.Book.Add(book);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            _context.Entry(book).State = System.Data.Entity.EntityState.Modified; 
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}