using System;
using System.Collections.Generic;

namespace PeeReview.Models
{
    public class Project
    {
        public string Name { get; private set; }
        public string ID { get; private set; }
        public Note Description { get; private set; }
        public int GroupSize { get; private set; }
        public defaultSetUniqueID IDSetter{get; private set; }
        public List<Group> Groups { get; }
        public DateTime DeadlineDateTime;
        public Course Course { get; private set; }
        public List<Assignment> Assignments { get; private set; }
        public DateTime ProjectDateTime { get; private set; }
        public string deadlineErrorMessage { get; private set; }

        Project(string name, string descrpition, Course course, string stringDeadlineDateTime  )
        {
            Name = name;
            Course = course;
            Description = new Note("Course Instructor", descrpition); 
            IDSetter = new defaultSetUniqueID();
            IDSetter.setUniqueID(ID);
            ProjectDateTime = DateTime.Now;
            setDeadline(stringDeadlineDateTime);
        }

        public void addGroup(string groupName)
        {
            // Groups.Add(group) TODO find group and add it
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

        public void setDeadline(string stringDeadlineDateTime)
        {
            if (!DateTime.TryParse(stringDeadlineDateTime, out DeadlineDateTime))
            {
                // handle parse failure
                DeadlineDateTime = DateTime.Today;
                deadlineErrorMessage = "Invalied date/time format! Date and time set to today's 00:00:00";
                //  return View(The view) TODO    
            }
        }
    }
}