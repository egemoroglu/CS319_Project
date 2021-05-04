using System;
using System.Collections;
using System.Collections.Generic;
using System.EnterpriseServices;
using PeeReview.Models;

namespace PeeReview.Models
{
    public abstract class User
    {
        public User(string name, string surName, string email, string password)
        {
            Name = name;
            SurName = surName;
            Email = email;
            Password = password;
            IDSetter = new defaultSetUniqueID();
            IDSetter.setUniqueID(ID);
        }

        public defaultSetUniqueID IDSetter { get; }

        public string Password { get; private set; }
        public string Name { get; private set; }
        public string SurName { get; private set; }
        public string Email { get; private set; }
        public string ID { get; private set; }
        public Picture Pic { get; private set; }
        public List<Course> courses { get; }
        public List<Project> projects { get; }
        public List<Assignment> assignments { get; }
        public List<Notification> notifications { get;}
        
        public void addAssignment(Assignment assignment)
        {
            assignments.Add(assignment);
        }

        public void removeAssignment(Assignment assignment)
        {
            assignments.Remove(assignment);
        }
        public void joinProjetc(Project project)
        {
            projects.Add(project);
        }

        public void leaveProject(Project project)
        {
            projects.Remove(project);
        }
        
        public void joinCourse(Course course)
        {
            courses.Add(course);
        }

        public void leaveCourse(Course course)
        {
            courses.Remove(course);
        }

    






    }

    
}