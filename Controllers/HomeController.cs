using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            IEnumerable<Book> books = db.Books;// получаем из бд все объекты Book
            ViewBag.Books = books;// передаем все объекты в динамическое свойство Books в ViewBag
            return View(); // возвращаем представление
        }
    }
    
     
  
}