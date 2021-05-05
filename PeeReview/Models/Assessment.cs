using System;
using System.Collections.Generic;

namespace PeeReview.Models
{
    public class Assessment //grades for submissions are saved here
    {
        public defaultSetUniqueID IDSetter { get; set; }
        public string ID { get; private set; }
        public Dictionary<string,int> marks { get; private set; }
        public Review Review; //Will be instantiated in the controller

        public Assessment( Dictionary<string,int> marksPassed, Review review) //set in controller and then passed
        {
            foreach (KeyValuePair<string, int> mark in marksPassed)
            {
                this.marks.Add(mark.Key,mark.Value);
            }
            Review = review;
            IDSetter = new defaultSetUniqueID();
            IDSetter.setUniqueID(ID);
        }
        Assessment()
        {
            IDSetter.setUniqueID(ID);
        }

        private void giveMark(string criteria, int mark)
        {
            if (marks.ContainsKey(criteria))
                marks[criteria] = mark;
            else
            {
                
                marks.Add(criteria, mark); //
            }
        }
        private void deleteMark(string criteria,int mark)
        {
            if (marks.ContainsKey(criteria))
                marks[criteria] = -1; //basically deleted
            else
            {
                //throw error
            }
        }
        private void edit(string criteria,int mark)
        {
            if (marks.ContainsKey(criteria))
                marks[criteria] = mark;
            else
            {
                //error doesn't exist
                //or marks.Add(criteria, mark); //depends on implementation
            }
        }
        
    }
}