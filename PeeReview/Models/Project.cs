using System;
using System.Collections.Generic;

namespace PeeReview.Models
{
    public class Project
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int groupSize { get; private set; }

        public double grade;


        public void setGrade(double grade)
        {
            this.grade = grade;
        }


        public List<Group> groups { get; }
        public Course course { get; private set; }
        public List<Assignment> assignments { get; private set; }

        public void addGroup(Group group)
        { groups.Add(group);}
        public void removeGroup(Group group)
        { groups.Remove(group);}
        
    }
}