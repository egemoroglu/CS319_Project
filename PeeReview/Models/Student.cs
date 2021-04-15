using System;
using System.Collections.Generic;

namespace PeeReview.Models
{
    public class Student : User
    {
        private List<Group> groups;
        private List<Assignment> assignments;
        private List<Project> projects;
        public Student(string name, string surname,string email, Picture pic )
            : base( name,  surname, email,  pic ) { }

        public List<Group> getGroups()
        {
            return groups;
        }

        public List<Project> getGroupInCourse(Course course)
        {
            return course.getProjects();
        }

        public List<Project> getProjects()
        {
            return projects;
        }

        public List<Assignment> getAssignments()
        {
            return assignments;
        }

        public bool sendRequestToGroup(Course course, Group group)
        {
            return false; //TODO
        }

        public void leaveGroup()
        {
            //TODO
        }

        public void createGroup()
        {
            //TODO
        }

        public void deleteGroup()
        {
            //TODO
        }

    }
}