using System.Web.Mvc;

namespace PeeReview.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            Connector conn = new Connector("UserTable");
            var result = collection.Find(filter).ToList();
            if ()
            return View();
        }

        public ActionResult StudentMainPage()
        {
            return View("~/Views/StudentMainPage");
        }
        public ActionResult InstructorMainPage()
        {
            return View("~/Views/InstructorMainPage");
        }
        public ActionResult GraderMainPage()
        {
            return View("~/Views/GraderMainPage");
        }

        /**
        * Assuming data is taken from the ui
        * 
        */
        public bool LogInDal(string email, string pw)
        {
            //check email in system
            //check if it is the correct pw
            Connector conn = new Connector("UserTable");
            return conn.emailPassword(email,pw);
        }
    }
}