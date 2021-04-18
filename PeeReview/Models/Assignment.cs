using System.Collections.Generic;

namespace PeeReview.Models
{
    public class Assignment
    {
               
        public double grade;
        public string title;
        public string description;
        public List<Submission> Submissions;
        public List<CompletedSubmission> CompletedSubmissions;
        //Date class should be added.
        //public Date deadline;
        //preview 
        
        public Assignment(string title,string description)
        {
            this.title = title;
            this.description = description;
        }
        public void setGrade(double grade)
        {
            this.grade = grade;
        }

        //public void setDeadline()
        //{

        //}

    }
}