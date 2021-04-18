using System.Collections.Generic;
using NotImplementedException = System.NotImplementedException;

namespace PeeReview.Models
{
    public class Submission  //Needs more definition
    //Submission, List Files, Title, date, Comment 
    {
        public string Name { get; private set; }
        public Preview Preview { get; private set; }
        //public Date time { get; private set; }
        //file 
        public int UniqueID { get; private set; } //make this an interface?


        protected Submission(string name, Preview preview)
        {
            Name = name;
            Preview = preview;
            //TODO set date and time and unique ID
        }




    }
}