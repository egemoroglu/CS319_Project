using System.Collections.Generic;
using NotImplementedException = System.NotImplementedException;

namespace PeeReview.Models
{
     public class CompletedSubmission : Submission  //contains a submission after done and closed, now we can review it and evaluate it
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