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
            project.setGrade(grade);
        }
        protected void gradeAssignment(Assignment assignment, int grade)
        {
            assignment.setGrade(grade);
        }
        protected void extendDeadlineProject (Project project, float hours){
            //TODO
            //In this method we should get the project's deadline and add hours parameter to the deadline.
            //So, Date class should be added.
        }
        protected void extendDeadlineAssignment (Assignment assignment, float hours){
            //TODO
            //In this method we should get the assignment's deadline and add hours parameter to the deadline.
            //So, Date class should be added.
        }

        public List<Group> getGroupsInCourse(Course course)
        {
            return course.getGroups();
        }

        public List<Student> getStudentsInGroup(Group group) //Is this really needed?
        {
            return group.getStudents();
        }

        public List<Project> getProjects()
        {
            return projects;
        }

        public List<Instructor> getRelevantInstructors()
        {
            return relevantInstructors;
        }
    }
}