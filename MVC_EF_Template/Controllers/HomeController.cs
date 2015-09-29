using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_EF_Template.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Repositories.Repository <Models.Student> repo = new Repositories.Repository<Models.Student>();
            Repositories.BaseService<Models.Student> repo = new Repositories.BaseService<Models.Student>(new DAL.DatabaseContext());
            Models.Student stu = new Models.Student() { FirstMidName = "Lalo", LastName = "Landa", BirthDate = DateTime.Now };
            stu = repo.Find(x => x.ID.Equals(1));
          

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
    }
}