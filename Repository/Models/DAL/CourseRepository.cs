using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Models.DAL
{
    public class CourseRepository : Repository<Book>, ICourseRepository
    {
        public CourseRepository(DataContext context)
            : base(context)
        {
        }

        public IEnumerable<Book> GetTopSellingCourses(int count)
        {
            return PlutoContext.Book.OrderByDescending(c => c.RegDate).Take(count).ToList();
        }

        public IEnumerable<Book> GetCoursesWithAuthors(int pageIndex, int pageSize)
        {
            return PlutoContext.Book.OrderByDescending(c => c.RegDate)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public DataContext PlutoContext
        {
            get { return Context as DataContext; }
        }
    }
}