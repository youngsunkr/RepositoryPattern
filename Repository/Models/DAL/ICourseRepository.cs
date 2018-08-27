using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Models.DAL
{
    public interface ICourseRepository : IRepository<Book>
    {
        IEnumerable<Book> GetTopSellingCourses(int count);
        IEnumerable<Book> GetCoursesWithAuthors(int pageIndex, int pageSize);
    }
}