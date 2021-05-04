using System.Web.Mvc;

namespace PeeReview.Controllers
{
    public class SignUpController : Controller
    {
        public ActionResult SignupInstTa()
        {
            return View();
        }
        public ActionResult SignupStudent() //merge all detailed
        {
            return View();
        }
  
        /**
         * Assuming data given by user is string form
         */ 
        public bool SignUp(string name, string surname, string studentId, string email, string password)
        {
            Connector conn = new Connector("StudentTable");
            if (conn.userExist(email)) ; //HERE SEND UI ERROR MSG THIS EMAIL IS TAKEN
            else
            {
                conn.addStudent(new Models.Student(name, surname, email, password, null));
                //Check if email exist in system
                return true;
            }
            return false; //USER COULDNOT ADDED!!!!!
        }
    }
}