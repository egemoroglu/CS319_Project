using System.Collections.Generic;

namespace PeeReview.Models
{
    public interface CalcualteAverageEvaluationStrategy
    {
        Dictionary<string, double> getAverage(Evaluation eval);

    }
    
    //-----------------------------------------------------------------------------------------
    public class GroupCalculateAverageEvaluationsStrategy : CalcualteAverageEvaluationStrategy
    {
        public Group analyzedGroup { get; private set; }
        Dictionary<string, double> avgForEachCriteria = new Dictionary<string, double>(); // here we save the average for each evaluation
        
        GroupCalculateAverageEvaluationsStrategy( Group group)
        {
            analyzedGroup = group;                  
            avgForEachCriteria = getAverage(group.GroupEvaluation);
        }

        public Dictionary<string, double> getAverage(Evaluation eval) //this function to be called 
        {
            
            Dictionary<string, double> avgForEachCriteriaReturned = new Dictionary<string, double>(); // here we pass an evaluation and it returns its average
            double avg;
            
            foreach(KeyValuePair<string, List<int> > entry in eval.CriteriaAndGrade)
            {
                avg = 0;
                foreach (var evalVal in entry.Value)
                {
                    avg += evalVal;
                }

                avg /=  entry.Value.Count;
                avgForEachCriteriaReturned.Add(entry.Key, avg);
            }

            return avgForEachCriteriaReturned;
        }
    }
    //-------------------------------------------------------------------------------------
    
    public class StudentCalculateAverageEvaluationsStrategy : CalcualteAverageEvaluationStrategy
    {
        public Student analyzedStudent { get; private set; }
            Dictionary<string, double> avgForEachCriteria = new Dictionary<string, double>(); // here we save the average for each evaluation
            
            StudentCalculateAverageEvaluationsStrategy( Student student)
            {
                analyzedStudent = student;                  
                avgForEachCriteria = getAverage(student.peersEvaluation);
            }
    
            public Dictionary<string, double> getAverage(Evaluation eval)
            {
                
                Dictionary<string, double> avgForEachCriteriaReturned = new Dictionary<string, double>(); // here we pass an evaluation and it returns its average
                double avg;
                
                foreach(KeyValuePair<string, List<int> > entry in eval.CriteriaAndGrade)
                {
                    avg = 0;
                    foreach (var evalVal in entry.Value)
                    {
                        avg += evalVal;
                    }
    
                    avg /=  entry.Value.Count;
                    avgForEachCriteriaReturned.Add(entry.Key, avg);
                }
    
                return avgForEachCriteriaReturned;
            }
    }
}