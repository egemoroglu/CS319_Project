using System.Collections.Generic;

namespace PeeReview.Models
{
    public class Assessment
    {
        private List<int> marks { get; }
        public Review review; //Will be instantiated in the controller
        private void giveMark(int mark)
        {
            marks.Add(mark);
        }

        private void deleteMark(int mark)
        {
            marks.Remove(mark);
        }
        private void editMark(int mark)
        {
            var tempIndex = marks.FindIndex(x => x == mark); // Lambda function to return index so that we replace the old mark
            marks[tempIndex] = mark;
        }

        public Review getReview()
        {
            return review;
        }
        


    }
}