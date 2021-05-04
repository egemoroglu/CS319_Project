using System.Web.Mvc;

namespace PeeReview.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View();
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