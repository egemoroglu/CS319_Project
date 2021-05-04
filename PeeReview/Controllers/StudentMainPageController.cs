using System.Web.Mvc;
using PeeReview.Models;

namespace PeeReview.Controllers
{
    public class StudentMainPageController : Controller
    {
        public ActionResult MainPageStudents()
        {
            StudentMPViewModel modelPassed = new StudentMPViewModel();
            modelPassed.courses.Add(new Course("OOpCS319", "CS319", new Instructor("xx","ee","aa","123")));
            ViewBag.Message = modelPassed;
            return View();
        }

        public ActionResult AssignmentsStudent()
        {
            return View();
        }
        public ActionResult CoursesStudent()
        {
            StudentMPViewModel modelPassed = new StudentMPViewModel();
            modelPassed.courses.Add(new Course("OOpCS319", "CS319", new Instructor("xx","ee","aa","123")));
            ViewBag.Message = modelPassed;
            return View();
        }


    }
}