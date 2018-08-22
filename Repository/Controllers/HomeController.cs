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
            var data = from m in repository.GetBooks()
                       select m;

            //return View(data);
            return View(data.Take(5).ToList());
            //return View(db.Book.Take(10).ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            repository.InsertBook(book);
            repository.Save();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Book b = repository.GetBookByID(id);
            return View(b);
        }

        public ActionResult Delete(int id)
        {
            Book b = repository.GetBookByID(id);
            repository.Save();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id, Book b)
        {
            repository.DeleteBook(id);
            repository.Save();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Book b = repository.GetBookByID(id);
            return View(b);
        }

        [HttpPost]
        public ActionResult Edit(int id, Book book)
        {
            repository.UpdateBook(book);
            repository.Save();
            return RedirectToAction("Index");
        }
    }
}