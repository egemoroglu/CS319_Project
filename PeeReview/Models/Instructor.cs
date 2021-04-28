using System;
using System.Collections.Generic;

namespace PeeReview.Models

{
    public class Instructor : User
    {
        public List<Grader> Graders { get; }
        public List<Course> Courses { get; }

        public Instructor(string name, string surname, string email, Picture pic)
            : base(name, surname, email, pic) { }


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

        public void gradeAssignment(Assignment assignment, int grade)
        {

            
        }

        public void extendDeadlineProject(Project project, double hours)
        {

        }

        public void kickStudentFromCourse(Student student, Course course)
        {

        }

        public void addStudentToCourse(Student student, Course course)
        {

        }

        public void createNewCourse(string courseName, string courseCode)
        {
          //  Course course = new Course() { CourseName = courseName, CourseCode = courseCode };

          //  return course;
        }

        public bool removeCourse(Course course)
        {
            Courses.Remove(course);

            return true;
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

        public List<Group> getGroupsOfCourse(Course course)
        {
            return course.Groups;
        }

        public List<Student> getStudentsWithoutGroups(Course course)
        {
            return course.Students;
        }

        public bool randomlyAssignStudentsToGroups(Course course, int groupSize)
        {
            //TODO
            return false;
        }

        public void createGroupFromOutsiders(Course course, int groupSize)
        {
  
        }



        private void addCoursesGiven(Course courses)
        {

        }

        private void removeCoursesGiven(Course courses)
        {

        }

    }
}