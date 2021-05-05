using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace PeeReview.Models
{
    public class Grader : User
    {
        public Grader (string name, string surName, string email, string password)
            :base (name, surName, email, password) {}

        private List<Instructor> relevantInstructors;
        public void assessSubmssion(Submission submission,Assessment assessment)
        {
            submission.assess(assessment); 
        }
        protected void extendDeadlineProject (Project project, string newDeadlineString){
            
            project.setDeadline(newDeadlineString);
             
            
        }
        
        public void endorse(Comment  comment)
        {
            comment.setToEndorsed(this.Name); 
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

        public void assessProject(Project project, Assessment assessment)
        {
            project.assess(assessment);
        }
    }
}