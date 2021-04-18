namespace PeeReview.Models
{
    public class Response : Comment //Any response to a Comment subclass' object

    {
        public Response(string title, string content, string author, Review parentReview) : base(title, content, author)
        {
            ParentReview = parentReview;
        }

        public Review ParentReview { get; private set; }
        
    }
}