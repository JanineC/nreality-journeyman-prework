using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JourneyMan2.Models
{
    public class SaleItem
    {
        //
        // GET: /SaleItem/
        public int ItemId { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public double Amount { get; set; }
        public int Quantity { get; set; }
        public Category Category { get; set; }
    }
}

