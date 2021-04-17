namespace PeeReview.Models
{
    public class Notification //TODO
    {
        private string text;
        private string title;
        //private Date date;
        private User sender;

        public string getText()
        {       
            return text;
        }

        private void setText(string text)
        {       
            this.text = text;
        }

        public string getTitle()
        {       
            return title;
        }

        private void setTitle(string title)
        {       
            this.title = title;
        }

        //public Date getDate()
        //{
          //  return Date;
        //}

        //private void setDate(Date date)
        //{
          //  this.date = date;
        //}

        public User getSender()
        {
            return sender;
        }

        private void setSender(User sender)
        {
            this.sender = sender;
        }
        
    }
}
