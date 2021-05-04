using System.Collections.Generic;

namespace PeeReview.Models
{
    public class StudentMPViewModel
    {
        public StudentMPViewModel()
        {
            courses = new List<Course>();
            assignments = new List<Assignment>();
            evaluations = new List<Evaluation>();
            groups = new List<Group>();
        }

        public List<Course> courses { get; set; }
        public List<Assignment> assignments{ get; set; }
        public List<Evaluation> evaluations{ get; set; }
        public List<Group> groups{ get; set; }
    }
}