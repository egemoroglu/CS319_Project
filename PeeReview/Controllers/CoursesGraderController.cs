using System.Web.Mvc;

namespace PeeReview.Controllers
{
  //  [Route("[controller]")]
    public class CoursesGraderController : Controller
    {
        public ActionResult EvaluateTeamMembers()
        {
            return View();
        }
    }
}