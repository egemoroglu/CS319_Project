using System.Web.Mvc;
using PeeReview.Models;

namespace PeeReview.Controllers
{
    public class AssignmentController : Controller
    {
        public ActionResult ReviewResponses()
        {
            
            return View();
        }
        public ActionResult DetailedAssignmentStudent() //merge all detailed
        {
            
            return View();
        }
        public ActionResult GroupAssignmentsStudent()//merge all assignment
        {
            return View();
        }
        public ActionResult DetailedCompletedAssignmentStudent() //merge all detailed
        {
            return View();
        }
        
    }
}