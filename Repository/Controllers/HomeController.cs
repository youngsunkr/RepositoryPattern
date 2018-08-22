using Repository.Models;
using Repository.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Repository.Controllers
{
    public class HomeController : Controller
    {
        //DataContext db = new DataContext();

        private IBookRepository repository;

        public HomeController()
        {
            this.repository = new BookRepository(new DataContext());
        }

        public ActionResult Index()
        {
            var data = from m in repository.GetConetnt()
                       select m;

            //return View(data);
            return View(data.Take(5).ToList());
            //return View(db.Book.Take(10).ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}