using PassingDataFromRazorToJavaScript.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PassingDataFromRazorToJavaScript.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = GetPersons();
            return View(model);
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


        private List<Person> GetPersons()
        {
            var persons = new List<Person>
            {
                new Person { Id = 1, Name = "Person 1", Email = "person1@email.com", PhoneNumber = "1111-111-111" },
                new Person { Id = 2, Name = "Person 2", Email = "person2@email.com", PhoneNumber = "2222-222-222" },
                new Person { Id = 3, Name = "Person 3", Email = "person3@email.com", PhoneNumber = "3333-333-333" }
            };
            return persons;

        }
    }
}