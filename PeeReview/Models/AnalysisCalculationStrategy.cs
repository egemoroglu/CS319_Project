using System.Collections.Generic;
using System.Drawing;

namespace PeeReview.Models
{
    /*
     *This whole strategy's class purpose is to provide useful data for the instructor
     * and for the visualization class
     * 
     */
    public interface AnalysisCalculationStrategy
    {
        Dictionary<string, double> calcAvgOfAvgs( Group AnalyzedGroup);
        Dictionary<string, string> lowOutlierEachCriteria( Group AnalyzedGroup);
        Dictionary<string, string> highOutlierEachCriteria( Group AnalyzedGroup);
       
    }

    public class GroupAnalysisCalculationStrategy: AnalysisCalculationStrategy
    {
       
        /*
         *In this method we visit every student element in the group then we get his average eval for each criteria,
         * Then we add this Dictionary element in a new dictionary that takes a criteria and a list of grades
         * Afterwards, we call a method to get the average of the values in the dictionary and return a new dictionary 
         * with these values
         * The data here will be passed to the visualizer class created by the views people
         */
        public double calcChemsitry(Group AnalyzedGroup) //extra function that is related 
        {
            Dictionary<string, double> groupAvg = calcAvgOfAvgs(AnalyzedGroup);
            double returnedAvg = 0;
            foreach (KeyValuePair<string, double> grade in groupAvg )
            {
                returnedAvg += grade.Value;
            }

            returnedAvg /= groupAvg.Count;
            return returnedAvg;
        }

        public Dictionary<string, double> calcAvgOfAvgs( Group AnalyzedGroup) //get the average of grade for each citeria for each student
        {
            Dictionary<string, List<double>> tempAvgs = new Dictionary<string, List<double>>(); //We save the avgs for each criteria here
            Dictionary<string, double> studentsTemps = new Dictionary<string, double>(); // This one holds the average for each student
            foreach (var student in AnalyzedGroup.students) 
            {
                studentsTemps = student.peersEvaluation.getAverage();
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

        public Dictionary<string, double> getAverage(Dictionary<string, List<double>> passedDict)   //Average for each criteria for any passed Dictionary
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

        public Dictionary<string, string> lowOutlierEachCriteria( Group AnalyzedGroup)  //Get the lowest student in each sriteria
        {
            Dictionary<string, string> ouliersReturned = new Dictionary<string, string>();
            Dictionary<string, double> lowestEachCriteria = new Dictionary<string, double>();
            Dictionary<string, double> tempStudentAvg = new Dictionary<string, double>();
            Dictionary<string, double> groupAvg = calcAvgOfAvgs(AnalyzedGroup);
            foreach (var student in AnalyzedGroup.students)
            {
                
                tempStudentAvg =  student.peersEvaluation.getAverage();
                foreach (KeyValuePair<string, double> criteria in tempStudentAvg)
                {
                    if (groupAvg[criteria.Key] <= (criteria.Value)) // is smaller than average?
                    {
                        if (lowestEachCriteria.ContainsKey(criteria.Key)) //if this criteria exists then compare to its value
                        {
                            if ((criteria.Value) > lowestEachCriteria[criteria.Key]) //then is it smaller than smallest?
                            {
                                lowestEachCriteria[criteria.Key] = (criteria.Value);
                                ouliersReturned[criteria.Key] = student.Name;

                            }
                        }
                    
                        else
                        { //firts check add the largest to the list 
                            lowestEachCriteria.Add(criteria.Key,criteria.Value);
                            ouliersReturned.Add(criteria.Key, student.Name);
                        }
                    }
                    
                }
            }

            return ouliersReturned;
        }

        public Dictionary<string, string> highOutlierEachCriteria( Group AnalyzedGroup)//get the highest student for each criteria
        {
            Dictionary<string, string> ouliersReturned = new Dictionary<string, string>();
            Dictionary<string, double> highestEachCriteria = new Dictionary<string, double>();
            Dictionary<string, double> tempStudentAvg = new Dictionary<string, double>();
            Dictionary<string, double> groupAvg = calcAvgOfAvgs(AnalyzedGroup);
            foreach (var student in AnalyzedGroup.students)
            {
                
                tempStudentAvg =  student.peersEvaluation.getAverage();
                foreach (KeyValuePair<string, double> criteria in tempStudentAvg)
                {                    
                    if (groupAvg[criteria.Key] <= (criteria.Value)) // is larger than average?
                    {
                        if (highestEachCriteria.ContainsKey(criteria.Key)) //if this criteria exists then compare to its value
                        {
                            if ((criteria.Value) > highestEachCriteria[criteria.Key]) //then is it larger than largest?
                            {
                                highestEachCriteria[criteria.Key] = (criteria.Value);
                                ouliersReturned[criteria.Key] = student.Name;

                            }
                        }
                    
                        else
                        { //firts check add the largest to the list 
                            highestEachCriteria.Add(criteria.Key,criteria.Value);
                            ouliersReturned.Add(criteria.Key, student.Name);
                        }
                       

                    }
                }
            }

            return ouliersReturned;
        }
    }
    
    /// <summary>
    /// The next class is the same as the one above but for assignment so get the avgs of assignment and the best and worst grade for he assignments
    /// This is used when multiple graders 
    /// </summary>
    public class SubmissionGroupsAnalysisCalculationStrategy : AnalysisCalculationStrategy
    {
        public Dictionary<string, double> calcAvgOfAvgs(Group AnalyzedGroup) //get the average of grade for each citeria for each submission
        {
            Dictionary<string, List<double>> tempAvgs = new Dictionary<string, List<double>>(); //We save the avgs for each criteria here
            Dictionary<string, double> SubmissionsTemps = new Dictionary<string, double>(); // This one holds the average for each submission
            foreach (Submission submission in AnalyzedGroup.submissions) 
            {
                SubmissionsTemps = submission.Evaluation.getAverage(); //get the average grade for each criteria in submission
                foreach (KeyValuePair<string, double> criteria in SubmissionsTemps) //we will ge the average of each criteria in the submission 
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
        
        public Dictionary<string, double> getAverage(Dictionary<string, List<double>> passedDict)   //Average for each criteria for any passed Dictionary
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
        

        public Dictionary<string, string> lowOutlierEachCriteria(Group AnalyzedGroup)
        {
            Dictionary<string, string> ouliersReturned = new Dictionary<string, string>();
            Dictionary<string, double> lowestEachCriteria = new Dictionary<string, double>();
            Dictionary<string, double> tempSubmissionAvg = new Dictionary<string, double>();
            Dictionary<string, double> groupAvg = calcAvgOfAvgs(AnalyzedGroup);
            foreach (Submission submission in AnalyzedGroup.submissions)
            {
                
                tempSubmissionAvg =  submission.Evaluation.getAverage();
                foreach (KeyValuePair<string, double> criteria in tempSubmissionAvg) //Notice we check the criteria in assignments just in case criteria in assignments were different so we get no error
                {
                    if (groupAvg[criteria.Key] >= (criteria.Value)) // is lower than average?
                    {
                        if (lowestEachCriteria.ContainsKey(criteria.Key)) //if this criteria exists then compare to its value
                        {
                            if ((criteria.Value) < lowestEachCriteria[criteria.Key]) //then is it smaller than smallest?
                            {
                                lowestEachCriteria[criteria.Key] = (criteria.Value);
                                ouliersReturned[criteria.Key] = submission.Name;

                            }
                        }
                    
                    else
                        { //firts check add the lowest to the list 
                                lowestEachCriteria.Add(criteria.Key,criteria.Value);
                                ouliersReturned.Add(criteria.Key, submission.Name);
                        }
                    }
                    
                }
            }

            return ouliersReturned;
        }

        public Dictionary<string, string> highOutlierEachCriteria(Group AnalyzedGroup)
        {
            Dictionary<string, string> ouliersReturned = new Dictionary<string, string>();
            Dictionary<string, double> highestEachCriteria = new Dictionary<string, double>();
            Dictionary<string, double> tempSubmissionAvg = new Dictionary<string, double>();
            Dictionary<string, double> groupAvg = calcAvgOfAvgs(AnalyzedGroup);
            foreach (Submission submission in AnalyzedGroup.submissions)
            {
                
                tempSubmissionAvg =  submission.Evaluation.getAverage();
                foreach (KeyValuePair<string, double> criteria in tempSubmissionAvg)
                {
                    
                    if (groupAvg[criteria.Key] <= (criteria.Value)) // is larger than average?
                    {
                        if (highestEachCriteria.ContainsKey(criteria.Key)) //if this criteria exists then compare to its value
                        {
                            if ((criteria.Value) > highestEachCriteria[criteria.Key]) //then is it larger than largest?
                            {
                                highestEachCriteria[criteria.Key] = (criteria.Value);
                                ouliersReturned[criteria.Key] = submission.Name;

                            }
                        }
                    
                        else
                        { //firts check add the largest to the list 
                            highestEachCriteria.Add(criteria.Key,criteria.Value);
                            ouliersReturned.Add(criteria.Key, submission.Name);
                        }
                    }
    
                }
            }

            return ouliersReturned;
        }
        
    }
}


