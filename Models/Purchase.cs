using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Purchase
    {
        //ID purchase
        public int PurchaseId { get; set; }
        //Name and Surname purchaser
        public string Person { get; set; }
        //Address of purchaser
        public string Address { get; set; }
        //ID books
        public int BookId { get; set; }
        //Datetime purchase
        public DateTime Date { get; set; }

    }
}