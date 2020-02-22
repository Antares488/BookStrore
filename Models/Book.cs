using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        //ID книг
        public int Id { get; set; }
        //название книг
        public string Name { get; set; }
        //автор книг
        public string Author {get;set;}
        //цена
        public int Price { get; set; }

    }
}