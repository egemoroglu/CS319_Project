using PeeReview.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PeeReview.Controllers
{
    public class CourseController : Controller
        //Status: Testing
    {
        List<Course> courses = new List<Course>();

        public ActionResult CreateProject()
        {
            return View();
        }
        public ActionResult DetailedCoursePageStudent() //merge all detailed
        {
            Course course = new Course("OOP design", "CS319", new Instructor("InstrFR", "instrSu", "Instr@", "123"));
            ViewBag.Message = course;
            return View();
        }

        public List<Course> RetrieveCourses()
        {
            return courses;
        }
        public bool addCourse(Course courseToAdd)
        {
            courses.Insert(courses.Count, courseToAdd);
            //Add to db
            Connector conn = new Connector("CourseTable");
            conn.addCourse(courseToAdd);
            return true;
        }
        public bool removeCourse(Course courseToRemove)
        {
            courses.RemoveAt(GetIndex(courseToRemove));
            //remove from db
            //check db if it exists
            Connector conn = new Connector("CourseTable");
            conn.removeCourse(courseToRemove);
            return true;
        }
        public int GetIndex(Course course)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (course.CourseCode == courses[i].CourseCode) return i;
            }
            return -1;
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