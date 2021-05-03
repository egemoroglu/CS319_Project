using System;
using System.Collections;
using System.Collections.Generic;
using System.EnterpriseServices;
using PeeReview.Models;

namespace PeeReview.Models
{
    public abstract class User
    {
        public User(string name, string surName, string email, string password,Picture pic)
        {
            Name = name;
            SurName = surName;
            Email = email;
            Password = password;
            Pic = pic;
            IDSetter.setUniqueID(ID);
        }

        public defaultSetUniqueID IDSetter { get;}

        public string Password { get; private set; }
        public string Name {get; private set; }
        public string SurName { get; private set; }
        public string Email { get; private set; }
        public string ID { get; private set; }
        public Picture Pic { get; private set; }
        List<Course> courses { get;}
        List<Project> projects { get;}
        List<Notification> notifications { get;}

        public void joinCourse()
        {
           //access the courses from database and add student
        }

        public void leaveCourse()
        {
            //access the courses from database and remove student
        }

    






    }

    
}