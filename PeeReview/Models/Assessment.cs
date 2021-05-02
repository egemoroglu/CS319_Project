using System;
using System.Collections.Generic;

namespace PeeReview.Models
{
    public class Assessment
    {
        public defaultSetUniqueID IDSetter { get; set; }
        public string ID { get; private set; }
        private List<int> marks { get; }
        public Review Review; //Will be instantiated in the controller

        Assessment(List<int> marks, Review review)
        {
            foreach (var mark in marks)
            {
                this.marks.Add(mark);
            }
            Review = review;
            IDSetter.setUniqueID(ID);
        }
        Assessment()
        {
            IDSetter.setUniqueID(ID);
        }

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
        
    }
}