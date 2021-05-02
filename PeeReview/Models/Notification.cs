using System;

namespace PeeReview.Models
{
    public class Notification 
    {
        public string Text { get; private set; }

        public string Title { get; private set; }

        public DateTime NotificationDateTime { get;}

        public User Sender { get; private set; }

        public Notification(string title, string text, string senderName)
        {
            Title = title;
            Text = text;
            //TODO find user and assign
            NotificationDateTime = DateTime.Now;
            
        }
    }
}
