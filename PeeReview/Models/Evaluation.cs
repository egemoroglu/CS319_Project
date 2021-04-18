using System.Collections.Generic;

namespace PeeReview.Models
{
    public class Evaluation 
    {
        public List<string> Criteria { get; }
        //We might need to add author checking to know if they are from the same group or different, or if TAs or instructor
        public Evaluation(List<string> Criteria)
        {
            this.Criteria = Criteria;
        }

        // We are gonna use a bunch of interfaces and base classes for this part 
        /*
         * CriteriaAndGrade is a Dictionary with keys and values, each key takes one values only
         * We add a default 0 to values intitially and then assign the real grade once evaluation is done
         * adding the grade and changing it is all done in gradeCriteria method
         */
        public Dictionary<string, int> CriteriaAndGrade { get; } 

        

        public void addCriteria(string newCriteria)
        {
            Criteria.Add(newCriteria);
            CriteriaAndGrade.Add(newCriteria,-1); //assigning 0 as a default value for grade
        }

        public void removeCirteria(string criteriaToRemove)
        {
            Criteria.Remove(criteriaToRemove);
            CriteriaAndGrade.Remove(criteriaToRemove);
        }
        
        public void gradeCriteria(string criteriaToEvaluate, int grade) //adding and changing is all done here 
        {
            CriteriaAndGrade.Add(criteriaToEvaluate,grade); 
        }
        

    }
}