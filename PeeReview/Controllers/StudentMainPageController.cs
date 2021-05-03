using System.Web.Mvc;

namespace PeeReview.Controllers
{
    public class StudentMainPageController : Controller
    {
        public ActionResult MainPageStudents()
        {
            return View();
        }

        public ActionResult AssignmentsStudent()
        {
            return View();
        }
        public ActionResult CoursesStudent()
        {
            return View();
        }


    }
}