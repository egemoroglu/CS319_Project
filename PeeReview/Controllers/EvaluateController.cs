using System.Collections.Generic;
using System.Web.Mvc;
using PeeReview.Models;

namespace PeeReview.Controllers
{
    public class EvaluateController : Controller
    {
        public ActionResult EvaluateOtherGroups()

        {
            List<string> cri = new List<string>{"communication", "work"};
            
            Evaluation evaluation = new Evaluation(cri);
            Group group = new Group("group victory",new Course("CS333","213",
                new Instructor("du","mm","yy","123"))) ;
            EvalauteViewModel evm = new EvalauteViewModel(evaluation, group);
            ViewBag.Message = evm;
            return View();
        }
        public ActionResult EvaluateTeamMembers() //merge all detailed
        {
            List<string> cri = new List<string>{"communication", "work"};
            Evaluation evaluation = new Evaluation(cri);
            ViewBag.Message = evaluation;
            return View();
        }
        
    }
}