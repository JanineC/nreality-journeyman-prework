using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           

            return View();
        }

        private string returnTable()
        {
            string result = string.Empty;

            StringBuilder myTable = new StringBuilder();
            myTable.Append("<table><tr>");
            for (var x = 1; x <= 100; x++)
            {
                if (x % 10 == 0)
                {
                    myTable.Append("</tr><tr>");
                }
                else
                {
                    myTable.Append(string.Format("{0}{1}{2}", "<td>", x, "</td>"));
                }
            }
            myTable.Append("</tr></table>");

            result = myTable.ToString();
            return result;
        }
    }
}
