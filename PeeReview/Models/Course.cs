using System.Collections.Generic;
using PeeReview.Controllers;

namespace PeeReview.Models
{
    public class Course //Possible need for change since properties with getters only are readonly
    {
        private List<Project> projects;
        private List<Group> groups;
        private List<Student> students;
        public string courseName { get; set; }
        public string courseCode { get; set; }
        public int courseGroupPolicy { get; private set; }
        public List<Instructor> instructors { get; }
        public List<Grader> graders { get; }
        public List<Submitted> submittedAssignments { get; }
        public AssignmentController assignments { get; }
        public GroupController groupController { get; }


        public Course()
        {
        }

        // implementation later
        public List<Student> getStudents()
        {
            return students;
        }

        public List<Project> getProjects()
        {
            return projects;
        }

        public List<Group> getGroups()
        {
            return groups;
        }

        public void addProject(Project project)
        {
            projects.Add(project);    
        }

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


        

    }
}
