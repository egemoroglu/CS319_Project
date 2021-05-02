using System;
using System.Security.AccessControl;

namespace PeeReview.Models
{
    public abstract class Comment : Note //parent of Preview and response
    {
        public string endorser { get; private set; }
        protected bool endorsed { get;  set; }

        public string Title { get; private set; }
        public string TextContent { get; private set; }
        public string Author { get; private set; }

        public DateTime postDateTime { get; private set; }

        public Comment Response { get; }
        protected Comment(string title, string textContent, string author) : base (author, textContent)
        {
            Title = title;
            postDateTime = DateTime.Now;
        }

        public void setToEndorsed(string endorserName)
        {
            endorsed = true;
            endorser = endorserName;
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