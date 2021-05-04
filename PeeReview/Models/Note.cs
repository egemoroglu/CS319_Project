namespace PeeReview.Models
{
    public class Note //A review of a submission, assignment or a group's info, the father of all texts added in system
    {
        public string Author { get; private set; }
        public string TextContent { get; private set; }
        public string ID { get; private set; }
        public defaultSetUniqueID IDSetter { get;private set; }

        public Note(string author, string textContent) 
        {
            Author = author;
            TextContent = textContent;
            IDSetter = new defaultSetUniqueID();
            IDSetter.setUniqueID(ID);
        }
    }
}