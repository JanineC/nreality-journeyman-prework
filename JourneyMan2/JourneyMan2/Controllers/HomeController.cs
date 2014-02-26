using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JourneyMan2.Models;

namespace JourneyMan2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public List<SaleItem> MyBasket;

        public ActionResult Index()
        {
            MyBasket = new List<SaleItem>();

            Category Chocolates = new Category()
            {
                CategoryType = "Candy",
                Details = "Sweet section"
            };

            

                MyBasket.Add(item: new SaleItem()
                {
                    ItemId = 1,
                    Category = Chocolates,
                    Description = "Mint Aero",
                    Details = "Cadbury's chocolate Bar ",
                    Amount = 5.00,  
                });


                MyBasket.Add(new SaleItem()
                {
                    ItemId = 2,
                    Category = Chocolates,
                    Description = "Smarties",
                    Details = "Wotalotigot chocolate pieces",
                    Amount = 3.50,
                });

                return View(MyBasket);
     
        }

        public double getTotal(int itemId, int numberOfItems)
        {
            SaleItem thisItem =  MyBasket.FirstOrDefault(x => x.ItemId == itemId);
            return thisItem.Amount * numberOfItems;

        }

        public double BuyXGetOneFree(SaleItem item, int x, int numberPurchased)
        {
            if (numberPurchased/x == 0)
                return 2.00;
            else
                return 3.00;
        }

    }
}
