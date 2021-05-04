using System.Web.Mvc;
using PeeReview.Models;

namespace PeeReview.Controllers
{
    public class InstructorMainPageController : Controller
    {
        public ActionResult AssignmentsInsTa()
        {
            Instructor instructor = new Instructor("instrName", "instrSur", "fe", "fers");
            ViewBag.Message = instructor;
            return View();
        }
        public ActionResult CoursesInstructor() //merge all detailed
        {
            Instructor instructor = new Instructor("instrName", "instrSur", "fe", "fers");
            ViewBag.Message = instructor;
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