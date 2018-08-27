using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Models.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);
            Books = new BookRepository(_context);
        }
        public ICourseRepository Courses { get; private set; }

        public IBookRepository Books { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}