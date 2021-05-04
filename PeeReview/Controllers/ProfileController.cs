using System.Web.Mvc;
using PeeReview.Models;

namespace PeeReview.Controllers
{
    public class ProfileController : Controller
    {
        public ActionResult Profile()
        {
            return View();
        }
    }
}