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

        public string ID { get; private set; }
        
        public Evaluation Evaluation { get; private set; }
        public Assessment Assessment { get; private set; }

        public CalculateAverageEvaluationsStrategyDefault averageCalculator { get; set; }

        //file 
        public defaultSetUniqueID IDSetter { get; } 


        protected Submission(string name, string overview, string submitterName)
        {
            Name = name;
            SubmitterName = submitterName;
            Overview = new Note(SubmitterName, overview);
            IDSetter = new defaultSetUniqueID();
            IDSetter.setUniqueID(ID);
            SubmissionDateTime = DateTime.Now;
     
        }

        public void evalaute(Evaluation eval)
        {
            Evaluation = eval;
        }
        public void assess(Assessment assessment)
        {
            Assessment = assessment;
        }



    }
}