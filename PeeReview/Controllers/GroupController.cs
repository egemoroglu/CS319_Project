using System.Web.Mvc;
using PeeReview.Models;

namespace PeeReview.Controllers
{
    public class GroupController : Controller
    {
        public ActionResult DetailedOtherGroupStudents()
        {
            Group group = new Group("group victory",new Course("CS333","213",
                new Instructor("du","mm","yy","123"))) ;
            ViewBag.Message = group;
            return View();
        }

        public ActionResult DetailedGroupPageInstTa()
        {
            Group group = new Group("group victory",new Course("CS333","213",new Instructor("du","mm","yy","123"))) ;
            ViewBag.Message = group;
            return View();

        }
        public ActionResult DetailedYourGroupStudents()
        {
            Group group = new Group("group victory",new Course("CS333","213",new Instructor("du","mm","yy","123"))) ;
            ViewBag.Message = group;
            return View();
        }

    }
}