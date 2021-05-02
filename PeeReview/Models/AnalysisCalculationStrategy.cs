using System.Collections.Generic;
using System.Drawing;

namespace PeeReview.Models
{
    public interface AnalysisCalculationStrategy
    {
        Dictionary<string, double> calcAvgOfAvgs();
        Dictionary<string, string> lowOutlierEachCriteria();
        Dictionary<string, string> highOutlierEachCriteria();
    }

    public class GroupAnalysisCalculationStrategy: AnalysisCalculationStrategy
    {
        private StudentCalculateAverageEvaluationsStrategy StudentCAES;
        public Group AnalyzedGroup { get; private set; }
        
        
        /*
         *In this method we visit every student element in the group then we get his average eval for each criteria,
         * Then we add this Dictionary element in a new dictionary that takes a criteria and a list of grades
         * Afterwards, we call a method to get the average of the values in the dictionary and return a new dictionary 
         * with these values
         */
        public Dictionary<string, double> calcAvgOfAvgs()
        {
            Dictionary<string, List<double>> tempAvgs = new Dictionary<string, List<double>>(); //We save the avgs for each criteria here
            Dictionary<string, double> studentsTemps = new Dictionary<string, double>(); // This one holds the average for each student
            foreach (var student in AnalyzedGroup.students) 
            {
                studentsTemps = student.calcAvg();
                foreach (KeyValuePair<string, double> criteria in studentsTemps)
                {
                    if (tempAvgs.ContainsKey(criteria.Key))
                    {
                        tempAvgs[criteria.Key].Add(criteria.Value); 
                    }
                    else 
                        tempAvgs.Add(criteria.Key, new List<double>{criteria.Value});
                }
            }
            return getAverage(tempAvgs);
        }

        public Dictionary<string, double> getAverage(Dictionary<string, List<double>> passedDict)
        {
            Dictionary<string, double> avgForEachCriteriaReturned = new Dictionary<string, double>();
            foreach (KeyValuePair<string, List<double>> entry in passedDict)
            {
                double avg = 0;
                foreach (var grade in entry.Value)
                { 
                    avg += grade;
                }
                avg /=  passedDict.Values.Count;
                avgForEachCriteriaReturned.Add(entry.Key, avg);
            }

            return avgForEachCriteriaReturned;
        }

        public Dictionary<string, string> lowOutlierEachCriteria()
        {
            
            throw new System.NotImplementedException();

        }

        public Dictionary<string, string> highOutlierEachCriteria()
        {
            throw new System.NotImplementedException();
        }
    }
}