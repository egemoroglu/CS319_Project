using PeeReview.Models;
using System.Web.Mvc;

namespace PeeReview.Controllers
{
    public class CourseController : Controller
    {
        public ActionResult CreateProject()
        {
            Course course = new Course("OOP","CS319", 
                new Instructor("Infrna", "InSur", "tr","223"));
            ViewBag.Message = course;
            return View();
        }
        public ActionResult DetailedCoursePageStudent() //merge all detailed
        {
            Course course = new Course("OOP","CS319", 
                new Instructor("Infrna", "InSur", "tr","223"));
            ViewBag.Message = course;
            return View();
        }

        public bool addCourse(Course courseToAdd)
        {
            //Add to db
            Connector conn = new Connector("CourseTable");
            conn.addCourse(courseToAdd);
            return true;
        }

        public bool removeCourse(Course courseToRemove)
        {
            //remove from db
            //check db if it exists
            Connector conn = new Connector("CourseTable");
            conn.removeCourse(courseToRemove);
            return true;
        }
  
        public ActionResult Enroll()//merge all assignment
        {
            return View();
        }
        
        public ActionResult GroupsPageStudent() //
       {
           Course course = new Course("OOP","CS319", 
               new Instructor("Infrna", "InSur", "tr","223"));
           ViewBag.Message = course;
            return View();
        }
    }
}