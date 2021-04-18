namespace PeeReview.Models
{
    public class Preview //A preview of a submission, assignment or a group's info, the father of all texts added in system
    {
        public string Author { get; private set; }
        public string TextContent { get; private set; }
        
        public int UniqueId { get; private set; }

        protected Preview(string author, string textContent) 
        {
            Author = author;
            TextContent = textContent;
            //TODO set uniqueID
        }
    }
}