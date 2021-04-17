using System;
using System.Collections.Generic;

namespace PeeReview.Models

{
    public class Instructor : User
    {
        private List<Grader> graders;
        private List<Course> courses;
        public Instructor(string name, string surname, string email, Picture pic)
            : base(name, surname, email, pic) { }

        public List<Grader> getGraders()
        {
            return graders;
        }

        public void addGrader(Grader grader, Course course)
        {
            course.addGrader(grader);
        }

        public void removeGrader(Grader grader, Course course)
        {
            course.removeGrader(grader);
        }

        public void setProject(Course course, Project project)
        {
            //TODO
        }

        public bool gradeProject(Project project, int grade)
        {
            //TODO
            return false;
        }

        public bool gradeAssignment(Assignment assignment, int grade)
        {
            //TODO
            return false;
        }

        public bool extendDeadlineProject(Project project, double hours)
        {
            //TODO
            return false;
        }

        public bool kickStudentFromCourse(Student student, Course course)
        {
            course.removeStudent(student);

            return true;
        }

        public bool addStudentToCourse(Student student, Course course)
        {
            course.addStudent(student);

            return true;
        }

        public Course initializeNewCourse(string courseName, string courseCode)
        {
            Course course = new Course() { courseName = courseName, courseCode = courseCode };

            return course;
        }

        public bool removeCourse(Course course)
        {
            courses.Remove(course);

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
            return course.getGroups();
        }

        public List<Student> getStudentsWithoutGroups(Course course)
        {
            return course.getStudents();
        }

        public bool randomlyAssignStudentsToGroups(Course course, int groupSize)
        {
            //TODO
            return false;
        }

        public bool createGroupFromOutsiders(Course course, int groupSize)
        {
            //TODO
            return false;
        }

        public List<Course> getCourses()
        {
            return courses;
        }

        private bool addCoursesGiven(Course courses)
        {
            //TODO
            return false;
        }

        private bool removeCoursesGiven(Course courses)
        {
            //TODO
            return false;
        }

    }
}