using System.Collections.Generic;
using NotImplementedException = System.NotImplementedException;

namespace PeeReview.Models
{
     public class CompletedSubmission : Submission  //contains a submission after done and closed, now we can review it and evaluate it
    {
        private List<Review> Reviews { get; }
        private Assessment assessment;
        public Evaluation evaluations; //includes criteria and grades, controller should deal with adding them
        
        protected CompletedSubmission(string name, Preview preview, Assessment assessment) : base(name, preview)
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