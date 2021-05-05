using System.Web.Mvc;
using PeeReview.Models;

namespace PeeReview.Controllers
{
    public class SignUpController : Controller
        //Status: Testing
    {
        public ActionResult SignupInstTa()
        {
            SignUpAsInstructor("name","", "", "", "");
            return View();
        }
        public ActionResult SignupStudent() //merge all detailed
        {
            SignUpAsStudent("name","", "", "", "");
            return View();
        }

        /**
         * Assuming data given by user is string form
         */
        public bool SignUpAsStudent(string name, string surname, string studentId, string email, string password)
        {
            Connector conn = new Connector("StudentTable");
            if (conn.userExist(email)) ; //HERE SEND UI ERROR MSG THIS EMAIL IS TAKEN
            else
            {
                conn.addStudent(new Models.Student(name, surname, email, password));
                //Check if email exist in system
                return true;
            }
            return false; //USER COULDNOT ADDED!!!!!
        }
        public bool SignUpAsGrader(string name, string surname, string studentId, string email, string password)
        {
            Connector conn = new Connector("GraderTable");
            if (conn.userExist(email)) ; //HERE SEND UI ERROR MSG THIS EMAIL IS TAKEN
            else
            {
                conn.addGrader(new Models.Grader(name, surname, email, password));
                //Check if email exist in system
                return true;
            }
            return false; //USER COULDNOT ADDED!!!!!
        }
        public bool SignUpAsInstructor(string name, string surname, string studentId, string email, string password)
        {
            Connector conn = new Connector("InstructorTable");
            if (conn.userExist(email)) ; //HERE SEND UI ERROR MSG THIS EMAIL IS TAKEN
            else
            {
                conn.addInstructor(new Models.Instructor(name, surname, email, password));
                //Check if email exist in system
                return true;
            }
            return false; //USER COULDNOT ADDED!!!!!
        }
    }
}