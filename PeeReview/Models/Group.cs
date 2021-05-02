using System.Collections.Generic;

namespace PeeReview.Models
{
    public class Group
    {
        public GroupAnalysisCalculationStrategy analysis { get; private set; }
        public string name { get; private set; }
        private int uniqueCode;
        private double chemstryPoint; //double was favoured for smoother usage 

        public Evaluation GroupEvaluation { get; private set; }

        public List<Student> students { get; private set; }
        public List<Project> projects{ get; private set; }
        public List<Grader> graders{ get; private set; }
        public List<Assignment> assignments{ get; private set; }
        public Dictionary<string, double> groupAverageEvals { get; private set; }



        public void addStudent(Student student)
        {
            students.Add(student);
        }
        public void removeStudent(Student student) //change to private??
        {
            students.Remove(student);
        }

        
        public void addProject(Project project)
        {
            projects.Add(project);
        }
        public void removeProject(Project project)
        {
            projects.Remove(project);
        }

        public void addAssignment(Assignment assignment)
        {
            assignments.Add(assignment);
        }
        public void removeAssignment(Assignment assignment)
        {
            assignments.Remove(assignment);
        }

        
        public void addGrader(Grader grader)
        {
            graders.Add(grader);
        }
        public void removeGrader(Grader grader)
        {
            graders.Remove(grader);
        }

        public string calcChem()
        {
             chemstryPoint = analysis.calcChemsitry(this);
            switch (chemstryPoint)
            {
              case  var _ when (chemstryPoint == 10 && chemstryPoint >=9):
                  return "PERFECT!!";
              case var _ when (chemstryPoint < 9 && chemstryPoint >=8):
                  return "NICE MATCH!!";
              case  var _ when (chemstryPoint < 8 && chemstryPoint >=6):
                  return "LOOKS LIKE IT WORKED";
              case var _ when (chemstryPoint < 6 && chemstryPoint >= 4):
                  return "SOMETHING WAS WRONG, NO?";
              case  var _ when (chemstryPoint < 4 && chemstryPoint >0):
                  return "IF DISASTER WAS A GROUP!!";
              case  var _ when (chemstryPoint == 0):
                  return "Looks like the chemistry is not calculated yet! HOW DID YOU GET HERE???";
                  
              
            }

            return "The calculated chemistry is off for some reason!! Time to dubug!!";
        }

        public double getChemistry()
        {
            return chemstryPoint;
        }

        public Dictionary<string, double> calcEvalAvg()
        {
            groupAverageEvals = GroupEvaluation.getAverage();
            return groupAverageEvals;
        }
        
    }
}