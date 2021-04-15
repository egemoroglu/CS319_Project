using System.Collections.Generic;
using System.Security.Cryptography;

namespace PeeReview.Models
{
    public class Grader : User
    {
        public Grader (string name, string surName, string email, Picture pic)
            :base (name, surName, email, pic) {}

        private List<Instructor> relevantInstructors;
        //courseToGrade is redundant since we have courses already
        private List<Project> projects;

        protected void gradeProject(Project project, int grade)
        {
            //TODO
        }
        protected void gradeAssignment(Assignment assignment, int grade)
        {
            //TODO
        }
        protected void extendDeadlineProject (Project project, float hours){}
        protected void extendDeadlineAssignment (Assignment assignment, float hours){}

        public List<Group> getGroupsInCourse(Course course)
        {
            return course.getGroups();
        }

        public List<Student> getStudentsInGroup(Group group) //Is this really needed?
        {
            return group.getStudents();
        }
    }
}