using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JourneyManBinarySearch.Models;

namespace JourneyManBinarySearch.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public List<Movie> MyList;

        public ActionResult Index()
        {
            MyList = PopulateMovies();

            IOrderedEnumerable<Movie> mySortedList = MyList.OrderBy(s => s.Name);

            return View(mySortedList.ToList());
        }

        public ActionResult Search(string searchName)
        {
            List<Movie> myList = PopulateMovies().ToList();

            List<Movie> newList = (List<Movie>) myList.Where(s => s.Name.Equals(searchName)).ToList();
            int searchKey = BinarySearchForMatch(myList, s => System.String.Compare(s.Name, searchName, System.StringComparison.Ordinal));

            return View(newList.ToList());
        }


        public List<Movie> PopulateMovies()
        {
            MyList = new List<Movie>();

            MyList.Add(new Movie()
            { 
                Name ="Life Is Beautiful",
                Description = "A Jewish man has a wonderful romance with the help of his humour, but must use that same quality to protect his son in a Nazi death camp.",
                Year= 1997, 
                Genre= "Drama"
            });
            MyList.Add(new Movie()
            {
                Name = "Titanic",
                Description = "A seventeen-year-old aristocrat, expecting to be married to a rich claimant by her mother, falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.",
                Year = 1997,
                Genre = "Drama"
            });
            MyList.Add(new Movie()
            {
                Name = "Titanic",
                Description = "An unhappy married couple deal with their problems on board the ill-fated ship.",
                Year = 1953,
                Genre = "Drama"
            });
            MyList.Add(new Movie()
            {
                Name = "Argo",
                Description = "Acting under the cover of a Hollywood producer scouting a location for a science fiction film, a CIA agent launches a dangerous operation to rescue six Americans in Tehran during the U.S. hostage crisis in Iran in 1980.",
                Year = 2004,
                Genre = "Thriller"
            });
            MyList.Add(new Movie()
            {
                Name = "Anchorman 2: The Legend Continues",
                Description = "With the 70s behind him, San Diego's top rated newsman, Ron Burgundy, returns to take New York's first 24-hour news channel by storm.",
                Year = 2013,
                Genre = "Comedy"
            });
            return MyList;
        }

        public static int BinarySearchForMatch<T>(IList<T> list,
    Func<T, int> comparer)
        {
            int min = 0;
            int max = list.Count - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                int comparison = comparer(list[mid]);
                if (comparison == 0)
                {
                    return mid;
                }
                if (comparison < 0)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return ~min;
        }




    }
}
