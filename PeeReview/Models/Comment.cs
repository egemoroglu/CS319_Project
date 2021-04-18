using System;

namespace PeeReview.Models
{
    public abstract class Comment : Preview //parent of Preview and repsonse
    {
        public string Title { get; private set; }
        public string TextContent { get; private set; }
        public string Author { get; private set; }
        public int UniqueId { get; private set; }
        public Comment Response { get;  set; }
        //public Date time { get; private set; }
        protected Comment(string title, string textContent, string author) : base (author, textContent)
        {
            Title = title;
            TextContent = textContent;
            Author = author;
            //TODO set uniqueID
        }

        public void editTitle(string newTitle)
        {
            Title = newTitle;
        }

        public void editTextContent(string newContent)
        {
            TextContent = newContent;
        }
        
    }
}