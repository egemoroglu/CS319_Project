using System.Web.Mvc;
using PeeReview.Models;

namespace PeeReview.Controllers
{
    public class GroupController : Controller
        //Status: Testing
    {
        public ActionResult DetailedOtherGroupStudents()
        {
            Course course = new Course("Object course", "CS222", new Instructor("insr", "er", "wee@dw", "fewfw"));
            Project project = new Project("prNa", "Description here", course, "21/12/2021");
            course.addProject(project);
            Group group = new Group("group victory",new Course("CS333","213",new Instructor("du","mm","yy","123"))) ;
            course.addGroupToProject(group,project);
            ViewBag.Message = group;
            return View();
        }

        public ActionResult DetailedGroupPageInstTa()
        {
            Course course = new Course("Object course", "CS222", new Instructor("insr", "er", "wee@dw", "fewfw"));
            Project project = new Project("prNa", "Description here", course, "21/12/2021");
            course.addProject(project);
            Group group = new Group("group victory",new Course("CS333","213",new Instructor("du","mm","yy","123"))) ;
            course.addGroupToProject(group,project);
            ViewBag.Message = group;
            return View();

        }
        public ActionResult DetailedYourGroupStudents()
        {
            Course course = new Course("Object course", "CS222", new Instructor("insr", "er", "wee@dw", "fewfw"));
            Project project = new Project("prNa", "Description here", course, "21/12/2021");
            course.addProject(project);
            Group group = new Group("group victory",new Course("CS333","213",new Instructor("du","mm","yy","123"))) ;
            //course.addGroupToProject(group,project);
            ViewBag.Message = group;
            return View();
        }

    }
}