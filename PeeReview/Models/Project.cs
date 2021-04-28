using System;
using System.Collections.Generic;

namespace PeeReview.Models
{
    public class Project
    {
        public string Name { get; private set; }
        public Note Description { get; private set; }
        public int GroupSize { get; private set; }
        public defaultSetUniqueID ID{get; private set; }
        public List<Group> Groups { get; }
        public Course Course { get; private set; }
        public List<Assignment> Assignments { get; private set; }

        Project(string name, string descrpition, Course course )
        {
            Name = name;
            Course = course;
            Description = new Note("Course Instructor", descrpition); 
            ID.setUniqueID();
        }

        public void addGroup(string groupName)
        {// Groups.Add(group) TODO find group and add it
         }

        public void removeGroup(Group group)
        {
            //Groups.Remove(group);
            // Groups.Add(group) TODO find group and add it
            
        }
        
        public void addAssignment(Assignment assignment)
        {
            Assignments.Add(assignment);
        }

        public void removeAssignment(Assignment assignment)
        {
            Assignments.Remove(assignment);
        }
    }
}