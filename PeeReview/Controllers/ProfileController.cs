using System.Web.Mvc;
using PeeReview.Models;

namespace PeeReview.Controllers
{
    public class ProfileController : Controller
        //Status: Testing
    {
        public ActionResult Profile()
        {
            return View();
        }
    }
}