using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMovie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult MoviewList()
        {
            var res = Movie.GetFilme("");


            Genre genre = new Genre
            {
                Id = 1,
                Name = ""
            };


            var result = JsonConvert.DeserializeObject<Genre>(res.ToString());

            return View(res.ToList());
        }
    }

    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}