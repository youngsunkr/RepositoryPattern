using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Models.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        IBookRepository Books { get; }

        int Complete();
    }
}