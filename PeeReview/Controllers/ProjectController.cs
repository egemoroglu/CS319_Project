using System.Runtime.Remoting.Messaging;
using System.Web.Mvc;
using PeeReview.Models;

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
            Course course = new Course("OOOOPP", "CS319",new Instructor("fiIs","fiSu","qw@", "123"));
                course.addProject(new Project("desgin", "this is our", course, "23/12/2021"));
                course.addStudent(new Student("StFr","StSur","12@sda", "123"));
                course.addStudent(new Student("ststst","StrsstrSur","12@sda", "123"));
                course.addStudent(new Student("xcsd","zxcz","12@sda", "123"));
                course.addStudent(new Student("lnkkp","lkm;lk","12@sda", "123"));
                ViewBag.Message = course;
            return View();
        }
        public ActionResult CreateGroup() //merge all detailed
        {
            Course course = new Course("OOOOPP", "CS319",new Instructor("fiIs","fiSu","qw@", "123"));
            course.addProject(new Project("desgin", "this is our", course, "23/12/2021"));
            course.addStudent(new Student("StFr","StSur","12@sda", "123"));
            course.addStudent(new Student("ststst","StrsstrSur","12@sda", "123"));
            course.addStudent(new Student("xcsd","zxcz","12@sda", "123"));
            course.addStudent(new Student("lnkkp","lkm;lk","12@sda", "123"));
            ViewBag.Message = course;
            return View();
        }
        public ActionResult FindGroupForStudent()//merge all assignment
        {
            Course course = new Course("OOOOPP", "CS319",new Instructor("fiIs","fiSu","qw@", "123"));
            course.addProject(new Project("desgin", "this is our", course, "23/12/2021"));
            course.addStudent(new Student("StFr","StSur","12@sda", "123"));
            course.addStudent(new Student("ststst","StrsstrSur","12@sda", "123"));
            course.addStudent(new Student("xcsd","zxcz","12@sda", "123"));
            course.addStudent(new Student("lnkkp","lkm;lk","12@sda", "123"));
            ViewBag.Message = course;
            return View();
        }
        public ActionResult GradingGroupPageInstTa() //merge all detailed
        {
            Course course = new Course("OOOOPP", "CS319",new Instructor("fiIs","fiSu","qw@", "123"));
            course.addProject(new Project("desgin", "this is our", course, "23/12/2021"));
            course.addStudent(new Student("StFr","StSur","12@sda", "123"));
            course.addStudent(new Student("ststst","StrsstrSur","12@sda", "123"));
            course.addStudent(new Student("xcsd","zxcz","12@sda", "123"));
            course.addStudent(new Student("lnkkp","lkm;lk","12@sda", "123"));
            ViewBag.Message = course;
            return View();
        }
        public ActionResult GradingIndividuallyPageInstTa()
        {
            Course course = new Course("OOOOPP", "CS319",new Instructor("fiIs","fiSu","qw@", "123"));
            course.addProject(new Project("desgin", "this is our", course, "23/12/2021"));
            course.addStudent(new Student("StFr","StSur","12@sda", "123"));
            course.addStudent(new Student("ststst","StrsstrSur","12@sda", "123"));
            course.addStudent(new Student("xcsd","zxcz","12@sda", "123"));
            course.addStudent(new Student("lnkkp","lkm;lk","12@sda", "123"));
            ViewBag.Message = course;
            return View();
        }
        public ActionResult SendRequestToJoinAGroup() //merge all detailed
        {
            Course course = new Course("OOOOPP", "CS319",new Instructor("fiIs","fiSu","qw@", "123"));
            course.addProject(new Project("desgin", "this is our", course, "23/12/2021"));
            course.addStudent(new Student("StFr","StSur","12@sda", "123"));
            course.addStudent(new Student("ststst","StrsstrSur","12@sda", "123"));
            course.addStudent(new Student("xcsd","zxcz","12@sda", "123"));
            course.addStudent(new Student("lnkkp","lkm;lk","12@sda", "123"));
            ViewBag.Message = course;
            return View();
        }
 
    }
}