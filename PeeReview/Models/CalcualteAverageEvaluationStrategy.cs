using System.Collections.Generic;

namespace PeeReview.Models
{
    public interface CalcualteAverageEvaluationStrategy
    {
        Dictionary<string, double> getAverage(Evaluation eval);

    }
    
    //-----------------------------------------------------------------------------------------
    public class CalculateAverageEvaluationsStrategyDefault : CalcualteAverageEvaluationStrategy
    {
       
        Dictionary<string, double> avgForEachCriteria = new Dictionary<string, double>(); // here we save the average for each evaluation
        
        CalculateAverageEvaluationsStrategyDefault(Evaluation eval )
        {
                 
            avgForEachCriteria = getAverage(eval);
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
    
    
}
