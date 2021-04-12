using System.Collections.Generic;
using PeeReview.Controllers;

namespace PeeReview.Models
{
    public class Course
    {
        public string courseName { get; private set; }
        public string courseCode { get; private set; }
        public int courseGroupPolicy { get; private set; }
        public int forumRestrictions { get; private set; }
        public Forum mainForum { get; }
        public List<Forum> forums { get; }
        public List<Instructor> instructors { get; }
        public List<Grader> graders { get; }
        public List<Student> students { get; }
        public List<Group> groups { get; }
        public List<Submitted> submittedAssignments { get; }
        public AssignmentController assignments { get; }
        public GroupController groupController { get; }
        public ForumController forumController { get; }

        // implementation later
        public bool addInstructor(Instructor intsr) //using a list here will complicate things 
        {
            return false;
        }

        public bool removeInstrucotr(Instructor instr)
        {
            return false;
        }

        public bool addGrader(Grader grader)
        {
            return false;
        }

        public bool removeGrader(Grader grader)
        {
            return false;
        }
        public bool addStudent(Student student)
        {
            return false;
        }

        public bool removeStudent(Student student)
        {
            return false;
        }
        //maybe use the name or code of forum instead??
        public bool addForum(Forum newForum)
        {
            return false;
        }
        public bool removeForum(Forum forumToRemove)
        {
            return false;
        }
        

    }
}