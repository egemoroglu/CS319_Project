using System;
using System.Collections.Generic;

namespace PeeReview.Models

{
    public class Instructor : User
    {
        public List<Grader> Graders { get; }

        public Instructor(string name, string surname, string email, string password, Picture pic)
            : base(name, surname, email, password, pic) { }


        public void addGrader(string graderName, string courseCode)
        {
            //TODO get grader and course assign them to each other
        }

        public void removeGrader(string graderName, string courseCode)
        {
            //TODO get grader and course delete
        }
        
        public void gradeProject(Project project, int grade)
        {

        }

        protected void gradeAssignment(Assignment assignment, int grade)
        {
            assignment.setGrade(grade);
        }

        public void endorse(Comment  comment)
        {
            comment.setToEndorsed(this.Name); 
        }

        protected void extendDeadlineProject (Project project, string newDeadlineString){
            
            project.setDeadline(newDeadlineString);
            //  return View(The view) TODO    
                

        }
        protected void extendDeadlineAssignment (Assignment assignment, string newDeadlineString){
            assignment.setDeadline(newDeadlineString);
        }

        public void removeStudentFromCourse(Student student, Course course)
        {
            //reach DB and do 
        }

        public void addStudentToCourse(Student student, Course course)
        {

        }

        public void createNewCourse(string courseName, string courseCode)
        {
          //  Course course = new Course() { CourseName = courseName, CourseCode = courseCode };

          //  return course;
        }

  

        public bool assignStudentToGroup(Student student, Group group, Course courseName)
        {
            group.addStudent(student);

            return true;
        }

        public bool assignTAToGroup(Grader grader, Group group)
        {
            group.addGrader(grader);
            return true;

        }

        public List<Group> getGroupsInCourse(Course course)
        {
            return course.Groups;
        }

        public List<Student> getStudentsWithoutGroups(Course course)
        {
            //reach from DB and add in course calss
            return course.Students;
        }

        public bool randomlyAssignStudentsToGroups(Course course, int groupSize)
        {
            //TODO
            return false;
        }

        public void createGroupFromOutsiders(Course course, int groupSize)
        {
        //later
        }

        public List<Student> getStudentsInGroup(Group group) //Is this really needed?
        {
            return group.students;
            
        }

        private void createCourse(Course courses)
        {
            //add to dateBase
        }

        private void removeCourse(Course courses)
        {
            //remove from dateBase

        }

    }
}