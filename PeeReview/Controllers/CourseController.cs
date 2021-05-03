using System.Web.Mvc;

namespace PeeReview.Controllers
{
    public class CourseController : Controller
    {
        public ActionResult CreateProject()
        {
            return View();
        }
        public ActionResult DetailedCoursePageStudent() //merge all detailed
        {
            return View();
        }
        public ActionResult Enroll()//merge all assignment
        {
            return View();
        }
        public ActionResult GroupsPageStudent() //
        {
            return View();
        }
    }
}