using System;
using System.Collections.Generic;
namespace PeeReview.Models
{
    public class Instructor : User
    {
        private List<Grader> graders;
        private List<Course> courses;
        public Instructor(string name, string surname,string email, Picture pic )
            : base( name,  surname, email,  pic ) { }

        public List<Grader> getGraders()
        {
            return graders;
        }
        
        public void addGrader(Grader grader, Course course)
        {
            course.getGraders().Add(grader);
        }

        public void removeGrader(Grader grader, Course course)
        {
            course.getGraders().Remove(grader);
        }

        public void setProject(Course course, Project project)
        {
            // To be implemented...
        }

        public bool gradeProject(Project project, int grade)
        {
            // To be implemented...
        }

        public bool gradeAssignment(Assignment assignment, int grade)
        {
            // To be implemented...
        }

        public bool extendDeadlineProject(Project project, float hours)
        {
            // To be implemented...
        }

        public bool kickStudentFromCourse(Student student, Course course)
        {
            course.getStudents().Remove(student);

            return true;
        }

        public bool addStudentToCourse(Student student, Course course)
        {
            course.getStudents().Add(student);

            return true;
        }

        public Course initializeNewCourse(string courseName, string courseCode)
        {
            Course course = new Course {courseName = courseName, courseCode = courseCode }

            return course;
        }

        public bool removeCourse(Course course)
        {
            courses.Remove(course);

            return true;
        }

        public bool assignStudentToGroup(Student student, Group group, Course courseName)
        {
            group.getStudents().Add(student);

            return true;
        }

        public bool assignTAToGroup(Grader grader, Group group)
        {
            group.getGraders().Add(grader);
        }

        public List<Group>getGroupsOfCourse(Course course)
        {
            return course.getGroups();
        }

        public List<Student> getStudentsWithoutGroups(Course course)
        {
            return course.getStudents();
        }

        public bool randomlyAssignStudentsToGroups(Course course, int groupSize)
        {
            // To be implemented...
        }

        public bool createGroupFromOutsiders(Course course, int groupSize)
        {
            // To be implemented...
        }

        public Course getCourses()
        {
            return courses;
        }

        private bool addCoursesGiven(Course courses)
        {
            // To be implemented...
        }

        private bool removeCoursesGiven(Course courses)
        {
            // To be implemented...
        }




    }
}