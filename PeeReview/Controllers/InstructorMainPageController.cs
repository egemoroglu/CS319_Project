using System.Web.Mvc;
using PeeReview.Models;

namespace PeeReview.Controllers
{
    public class InstructorMainPageController : Controller
        //Status: Testing
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
            instructor.joinCourse(new Course("OOP","CS315",instructor));
            instructor.joinCourse(new Course("OOPDesign","CS319",instructor));
            ViewBag.Message = instructor;
            
            return View();
        }
        public ActionResult CreateAssignment()//merge all assignment
        {
            Instructor instructor = new Instructor("instrName", "instrSur", "fe", "fers");
            instructor.joinCourse(new Course("OOP","CS315",instructor));
            instructor.joinCourse(new Course("OOPDesign","CS319",instructor));
            ViewBag.Message = instructor;
            
            return View();
        }
        public ActionResult CreateCourse() //merge all detailed
        {
            Instructor instructor = new Instructor("instrName", "instrSur", "fe", "fers");
            instructor.joinCourse(new Course("OOP","CS315",instructor));
            instructor.joinCourse(new Course("OOPDesign","CS319",instructor));
            ViewBag.Message = instructor;
            return View();
        }

        public ActionResult mainPageInsTa()
        {
            Instructor instructor = new Instructor("instrName", "instrSur", "fe", "fers");
            instructor.joinCourse(new Course("OOP","CS315",instructor));
            instructor.joinCourse(new Course("OOPDesign","CS319",instructor));
            ViewBag.Message = instructor;
            return View();
        }
    }
}