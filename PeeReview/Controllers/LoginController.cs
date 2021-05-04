using PeeReview.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PeeReview.Controllers
{
    public class LoginController : Controller
    {
        List<Models.User> userList = new List<Models.User>();
        List<Models.Student> studentList = new List<Models.Student>();
        List<Models.Instructor> instructorList = new List<Models.Instructor>();
        List<Models.Grader> graderList = new List<Models.Grader>();

        public ActionResult Login()
        {
            //retreival of users here
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
        public User LogInDal(string email, string pw)
        {
            //check email in system
            //check if it is the correct pw
            Connector conn = new Connector("UserTable");
            if (conn.emailPassword(email, pw))
            {
                User user;
                for (int i = 0; i < userList.Count; i++)
                {
                    user = userList[i];
                    if (user.Email == email) return user;
                }
            }
            return null;
        }
    }
}