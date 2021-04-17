namespace PeeReview.Models
{
    public class Notification //TODO
    {
    private string body;
        private string head;
        private Date date;
        private User user;

        public string getHead()
        {       
            return head;
        }

        private void setHead(string head)
        {       
            this.head = head;
        }

        public string getBody()
        {       
            return body;
        }

        private void setBody(string body)
        {       
            this.body = body;
        }

        public Date getDate()
        {
            return Date;
        }

        private void setDate(Date date)
        {
            this.date = date;
        }

        public User getSender()
        {
            return sender;
        }

        private void setSender(User sender)
        {
            this.sender = sender
        }
        
    }
}
