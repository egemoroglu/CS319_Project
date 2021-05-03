using System.Web.Mvc;

namespace PeeReview.Controllers
{
    public class InstructorMainPageController : Controller
    {
        public ActionResult AssignmentsInsTa()
        {
            return View();
        }
        public ActionResult CoursesInstructor() //merge all detailed
        {
            return View();
        }
        public ActionResult CreateAssignment()//merge all assignment
        {
            return View();
        }
        public ActionResult CreateCourse() //merge all detailed
        {
            return View();
        }

        public ActionResult mainPageInsTa()
        {
            return View();
        }
    }
}