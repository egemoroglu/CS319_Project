using System.Collections.Generic;
using PeeReview.Controllers;

namespace PeeReview.Models
{
    public class Course //Possible need for change since properties with getters only are readonly
    // Maybe Instructor as a friend class
    {
        public List<Project> Projects { get; }
        public List<Group> Groups { get; }
        public List<Student> Students { get; }
        public string CourseName { get; set; }
        public string CourseCode { get;  set; }
        public int CourseGroupPolicy { get;  set; }
        public Instructor Instructor { get; private set; }
        public List<Grader> Graders { get; }
        public List<Submission> SubmittedAssignments { get; }
        public AssignmentController Assignments { get; }
        public GroupController GroupController { get; }
        public defaultSetUniqueID ID { get; private set; }

        public Course(string courseName, string courseCode, Instructor instructor)
        {
            CourseName = courseName;
            CourseCode = courseCode;
            Instructor = instructor;
            ID.setUniqueID();
        }

        // implementation later
        public void addProject(Project project)
        {
            Projects.Add(project);    
        }
        
        public void addGrader(string graderName)
        {
            
        }

        public void removeGrader(string graderName)
        {
           
        }
        public void addStudent(string studentName)
        {
        }

        public void removeStudent(string studentName)
        {
            
        }
    }
}
