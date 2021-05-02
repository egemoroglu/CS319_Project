using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PeeReview.Models
{
    public class Assignment
    {
               
        public double grade;
        public string title;
        public string description;
        public List<Submission> Submissions;
        public List<CompletedSubmission> CompletedSubmissions;
        public Assignment nextIteration { get; private set; }
        public DateTime AssignmentDateTime { get; }

        public DateTime deadlineDateTime;
        public string deadlineErrorMessage { get; private set; }
        
        //preview 
        
        public Assignment(string title,string description, string stringDeadlineDateTime)
        {
            this.title = title;
            this.description = description;
            AssignmentDateTime = DateTime.Now;
            setDeadline(stringDeadlineDateTime);

        }
        public void setGrade(double grade)
        {
            this.grade = grade;
        }

        public void setDeadline(string stringDeadlineDateTime)
        {
        if (!DateTime.TryParse(stringDeadlineDateTime, out deadlineDateTime))
        {
            // handle parse failure
            deadlineDateTime = DateTime.Today;
            deadlineErrorMessage = "Invalied date/time format! Date and time set to today's 00:00:00";
            //  return View(The view) TODO    
        }
        }

    }
}