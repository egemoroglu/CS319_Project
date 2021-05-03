using System.Web.Mvc;

namespace PeeReview.Controllers
{
    public class ProjectController : Controller
    {
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