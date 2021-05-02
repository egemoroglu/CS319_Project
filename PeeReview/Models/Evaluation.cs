using System.Collections.Generic;

namespace PeeReview.Models
{
    public class Evaluation 
    {
        public List<string> Criteria { get; }

        public List<int> marks { get; private set; }
        
        //We might need to add author checking to know if they are from the same group or different, or if TAs or instructor
        public Evaluation(List<string> Criteria)
        {
            this.Criteria = Criteria;
        }

        // We are gonna use a bunch of interfaces and base classes for this part 
        
        /*
         * CriteriaAndGrade is a Dictionary with keys and values, each key takes one values only
         * Outlier, avg,
         * Create evaluation, with the creation of assignemnt, and add criteria
         * 
         * We add a default 0 to values intitially and then assign the real grade once evaluation is done
         * adding the grade and changing it is all done in gradeCriteria method
         */
        public Dictionary<string,List<int>> CriteriaAndGrade { get; } 

        
        /*
         * We are gonna have evaluations for: assignment, users in groups.
         *
         * 
         */
        public void addCriteria(string newCriteria)
        {
            
            Criteria.Add(newCriteria);
            CriteriaAndGrade.Add(newCriteria, new List<int>()); //assigned values assigned to zero by default
        }

        public void removeCirteria(string criteriaToRemove)
        {
            if (CriteriaAndGrade.ContainsKey(criteriaToRemove))
            {
                Criteria.Remove(criteriaToRemove);
                CriteriaAndGrade.Remove(criteriaToRemove);
                
            }
            else
            {
                //throw error
            }
            
        }
        
        public void gradeCriteria(string criteriaToEvaluate, int grade) //adding and changing is all done here 
        {
            if (CriteriaAndGrade.ContainsKey(criteriaToEvaluate))
            {
                CriteriaAndGrade[criteriaToEvaluate].Add(grade);
            }
            else
            {
                CriteriaAndGrade[criteriaToEvaluate] = new List<int> { grade };
            }
           
        }
        

    }
}