using System;
using System.Collections;
using System.Collections.Generic;
using System.EnterpriseServices;
using PeeReview.Models;

namespace PeeReview.Models
{
    abstract class User
    {
        //User(string name, string surName, Picture pic); OOps! No constructors allowed in interfaces!
        
        public string name {get; private set; }
        public string surName { get; private set; }
        public string email { get; private set; }
        public Picture pic { get; private set; }
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