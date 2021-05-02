using System;
using System.Collections.Generic;

namespace PeeReview.Models
{
    public class Student : User
    {
        public Evaluation peersEvaluation { get; }
        public List<Group> Groups { get; private set; }
        public List<Assignment> Assignments { get; private set; }
        public List<Project> Projects { get; private set; }
        public Dictionary<string, double> currentAvg { get; private set; }
        
        public Student(string name, string surname,string email, Picture pic )
            : base( name,  surname, email,  pic ) { }




        public void addEvaluation(string criteria, int grade)
        {
            peersEvaluation.gradeCriteria(criteria, grade);
            
        }

        public void sendRequestToGroup(Course course, string groupName)
        {
            //TODO find group by name 
        }

        public void leaveGroup(string groupName)
        {
            //TODO find group by name 
        }
        
    }
}