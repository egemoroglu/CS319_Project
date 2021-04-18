namespace PeeReview.Models
{
    public class Assignment
    {
               
        public double grade;
        public string title;
        public string description;
        //Date class should be added.
        //public Date deadline;
        public Assignment(string title,string description)
        {
            this.title = title;
            this.description = description;
        }
        public void setGrade(double grade)
        {
            this.grade = grade;
        }

        //public void setDeadline()
        //{

        //}

    }
}