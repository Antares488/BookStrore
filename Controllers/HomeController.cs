﻿using BookStore.Models;
using BookStore.Util;
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
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.bookid = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Спасибо," + purchase.Person + ",за покупку!";
        }
        [HttpGet]
        public ActionResult GetBook()
        {
            return View();
        }
        [HttpPost]
        public string PostBook()
        {
            string title = Request.Form["title"];
            string author = Request.Form["author"];

            return title + " " + author;
        }
        public ActionResult Gethtml()
        {
            return new HtmlResult("<h2>Привет мир!</h2>");
        }
        public ActionResult GetImage()
        {
            string path = "../Content/Images/facepalme.jpg";
            return new ImageResult(path);
        }











    }




}