using System.Collections.Generic;
using NotImplementedException = System.NotImplementedException;

namespace PeeReview.Models
{
    /*
     * This class should be unused, since the evaluations are done even before grading
     * The evaluations are very flexible that the differnce between a "finished/archived" submission and unfinished is just the grades
     */
     public class CompletedSubmission : Submission  //This class should be unused, since the evaluations are done even before grading
         //contains a submission after done and closed, we can review it and evaluate it
    {
        private List<Review> Reviews { get; }
        private Assessment assessment;
        public Evaluation evaluations; //includes criteria and grades, controller should deal with adding them
        public string SubmitterName { get; private set; }

        public CompletedSubmission(string name, string overview, string submitterName,Assessment assessment) : base(name, overview, submitterName)
        {
            this.assessment = assessment;
        }
        public void addReview(Review review)
        {
            Reviews.Add(review);
        }
        
        public void removeReview(Review review)
        {
            Reviews.Remove(review);
        }      
  
    }
}