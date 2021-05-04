using PeeReview.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PeeReview.Controllers
{
    public class ProjectController : Controller
    {
        List<Group> groups = new List<Group>();

        public void AddProjectGroup(Project project, Group group)
        {
            groups.Insert(groups.Count, group);
            //Add to db
            Connector conn = new Connector("ProjectsTable");
            conn.addProjectGroup(project, group);
        }

        public void AddStudentGroup(Student student, Group group)
        {
            group.addStudent(student);
            Connector conn = new Connector("GroupTable");
            conn.addStudentGroup(student, group);
        }

        public ActionResult AssignStudentsToGroups()
        {
            return View();
        }
        public ActionResult CreateGroup() //merge all detailed
        {
            return View();
        }
        public ActionResult FindGroupForStudent()//merge all assignment
        {
            return View();
        }
        public ActionResult GradingGroupPageInstTa() //merge all detailed
        {
            return View();
        }
        public ActionResult GradingIndividuallyPageInstTa()
        {
            return View();
        }
        public ActionResult SendRequestToJoinAGroup() //merge all detailed
        {
            return View();
        }
 
    }
}