using System.Web.Mvc;
using PeeReview.Models;

namespace PeeReview.Controllers
{
    public class GraderMainPageController : Controller
        //Status: Testing
    {
        public ActionResult CoursesGrader()
        {
            Grader grader = new Grader("Grader 01", "Surnmae", "r@g","pass");
            ViewBag.Message = grader;
            return View();
        }

    }
}