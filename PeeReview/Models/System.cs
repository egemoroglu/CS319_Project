using System.Collections.Generic;
using System.Configuration;

namespace PeeReview.Models
{
    public class System //Change name, Singleton?
    {
        private List<Course> courses;
        private List<Grader> graders;
        private List<Student> students;
        private List<Instructor> instrucotrs;
        public List<Course> getCourses()
        {
            return courses;
        }
        public List<Student> getStudents()
        {
            return students;
        }
        public List<Grader> getGraders()
        {
            return graders;
        }
        public List<Instructor> getInstructord()
        {
            return instrucotrs;
        }

        protected void addCourse(Course course)
        {
            courses.Add(course);
        }

        protected void removeCourse(Course course) //Use name instead??
        {
            courses.Remove(course);
        }
        protected void addStudent(Student student)
        {
            students.Add(student);
        }

        protected void removeStudent(Student student) //Use name instead??
        {
            students.Remove(student);
        }
        protected void addGrader(Grader grader)
        {
            graders.Add(grader);
        }

        protected void removeGrader(Grader grader) //Use name instead??
        {
            graders.Remove(grader);
        }
        protected void addInstructor(Instructor instructor)
        {
            instrucotrs.Add(instructor);
        }

        protected void removeInstructor(Instructor instructor) //Use name instead??
        {
            instrucotrs.Remove(instructor);
        }

        private bool exists(User user)
        {
            return false; //TODO
        }
    }
}