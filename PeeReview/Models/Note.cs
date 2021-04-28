namespace PeeReview.Models
{
    public class Note //A review of a submission, assignment or a group's info, the father of all texts added in system
    {
        public string Author { get; private set; }
        public string TextContent { get; private set; }
        
        public defaultSetUniqueID uniqueID { get;private set; }

        public Note(string author, string textContent) 
        {
            Author = author;
            TextContent = textContent;
            uniqueID.setUniqueID();
        }
        public string getID()
        {
            return uniqueID.ID;
        }
    }
}