using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace PeeReview.Models
{
    public class Grader : User
    {
        public Grader (string name, string surName, string email, Picture pic)
            :base (name, surName, email, pic) {}

        private List<Instructor> relevantInstructors;
        protected void gradeAssignment(Assignment assignment, int grade)
        {
            assignment.setGrade(grade);
        }
        protected void extendDeadlineProject (Project project, string newDeadlineString){
            
            project.setDeadline(newDeadlineString);
            //  return View(The view) TODO    
                

        }
        protected void extendDeadlineAssignment (Assignment assignment, string newDeadlineString){
            assignment.setDeadline(newDeadlineString);
        }

        public List<Group> getGroupsInCourse(Course course)
        {
            return course.Groups;
        }

        public List<Student> getStudentsInGroup(Group group) //Is this really needed?
        {
            return group.students;
            
        }
        
        public List<Instructor> getRelevantInstructors()
        {
            return relevantInstructors;
        }
    }
}