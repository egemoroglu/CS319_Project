using System.Web.Mvc;

namespace PeeReview.Controllers
{
    public class EvaluateController : Controller
    {
        public ActionResult EvaluateOtherGroups()
        {
            return View();
        }
        public ActionResult EvaluateTeamMembers() //merge all detailed
        {
            return View();
        }
        
    }
}