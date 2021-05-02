namespace PeeReview.Models
{
    public class Review : Comment //Any text added as a review of a submission, in both grading and evaluating. 
    {
    


        public Submission ReviewedSubmission { get; private set; }
        
        
        public Review(string title, string textContent, string author, Submission reviewedSubmission) : base(title, textContent, author)
        {
            ReviewedSubmission = reviewedSubmission;
        }
        
    }
}