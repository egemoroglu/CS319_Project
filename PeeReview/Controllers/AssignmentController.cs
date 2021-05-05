using System.Web.Mvc;
using PeeReview.Models;

namespace PeeReview.Controllers
{
    public class AssignmentController : Controller
        //Status: Testing
    {
        public ActionResult ReviewResponses()
        {
            
            return View();
        }
        public ActionResult DetailedAssignmentStudent() //merge all detailed
        {
            
            return View();
        }
        public ActionResult DetailedAssignmentTa() //merge all detailed
        {
            
            return View();
        }
        public ActionResult DetailedAssignmentInst() //merge all detailed
        {
            
            return View();
        }
        public ActionResult GroupAssignmentsStudent()//merge all assignment
        {
            return View();
        }
        public ActionResult DetailedNotCompletedAssignmentStudent() //merge all detailed
        {
            return View();
        }
        public ActionResult DetailedCompletedAssignmentStudent() //merge all detailed
        {
            return View();
        }
        public ActionResult GroupAssignmentsInsTa() //merge all detailed
        {
            return View();
        }
        public bool AddAssignment(Assignment assignment)
        {
            //Add to db
            Connector conn = new Connector("AssignmentsTable");
            conn.AddAssignment(assignment);
            return true;
        }
    



    }
}