using System;
using System.Collections.Generic;
using NotImplementedException = System.NotImplementedException;

namespace PeeReview.Models
{
    public class Submission  //Needs more definition
    //Submission, List Files, Title, date, Comment 
    {
        public string Name { get; private set; }
        public Note Overview { get; private set; }

        public string SubmitterName { get; private set; }
        public DateTime SubmissionDateTime { get; private set; }

        //file 
        public defaultSetUniqueID ID { get; } 


        protected Submission(string name, string overview, string submitterName)
        {
            Name = name;
            SubmitterName = submitterName;
            Overview = new Note(SubmitterName, overview);
            ID.setUniqueID();
            SubmissionDateTime = DateTime.Now;
     
        }




    }
}