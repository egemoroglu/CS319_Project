using System;
using System.Collections;
using System.Collections.Generic;
using System.EnterpriseServices;
using PeeReview.Models;

namespace PeeReview.Models
{
    public abstract class User
    {
        public User(string name, string surName, string email, Picture pic)
        {
            Name = name;
            SurName = surName;
            Email = email;
            Pic = pic;
        }

        public string Name {get; private set; }
        public string SurName { get; private set; }
        public string Email { get; private set; }
        public Picture Pic { get; private set; }
        private Inbox inbox; // getter needs to be written using Inbox class methods
        List<Course> courses { get;}
        List<Project> projects { get;}
        List<Notification> notifications { get;}

        public bool joinCourse()
        {
            return false;
        }

        bool leaveCourse()
        {
            return false;
        }

        void sendMessage(Message msg){ }






    }

    
}