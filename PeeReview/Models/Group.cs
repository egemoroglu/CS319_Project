using System.Collections.Generic;

namespace PeeReview.Models
{
    public class Group
    {
        public Group(string name, Course parentCourse)
        {
            this.name = name;
            this.parentCourse = parentCourse;
            students = new List<Student>();
            projects = new List<Project>();
            graders = new List<Grader>();
            assignments = new List<Assignment>();
            groupAverageEvals = new Dictionary<string, double>();
            IDSetter.setUniqueID(ID);

        }
        
        public string name { get; private set; }
        public string ID { get; private set; }

        public defaultSetUniqueID IDSetter { get; private set; }


        private double chemstryPoint; //double was favoured for smoother usage 
        public Course parentCourse { get; set; }

        public Evaluation GroupEvaluation { get; private set; }
      
        //this isa  strategy that is used in graphs as they should be, bu they are useful here for raw data for instructor
        public AnalysisCalculationStrategy AnalysisStrategy { get; private set; }
       
        public List<Student> students { get; private set; }
        public List<Project> projects{ get; private set; }
        public List<Grader> graders{ get; private set; }
        public List<Assignment> assignments{ get; private set; }
        public List<Submission> submissions{ get; private set; }
        public Dictionary<string, double> groupAverageEvals { get; private set; }
        public Dictionary<string, double> sunbmissionsGroupAverage{ get; private set; }


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
        public void addSubmission(Submission submission)
        {
            submissions.Add(submission);
        }

        public void removeSubmission(Submission submission)
        {
            submissions.Remove(submission);
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
            GroupAnalysisCalculationStrategy studentAnalysis = new GroupAnalysisCalculationStrategy();
             chemstryPoint = studentAnalysis.calcChemsitry(this);
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
        public Dictionary<string, string> gethighestStudentInEachCriteria()
        {
            AnalysisStrategy = new GroupAnalysisCalculationStrategy();
            return AnalysisStrategy.highOutlierEachCriteria(this); //can use names to retrieve students if necessary fo rany features
        }
        public Dictionary<string, string> getLowestStudentInEachCriteria()
        {
            AnalysisStrategy = new GroupAnalysisCalculationStrategy();
            return AnalysisStrategy.lowOutlierEachCriteria(this);//can use names to retrieve students if necessary fo rany features
        }
        public Dictionary<string, string> gethighestAssignmentInEachCriteria()
        {
            AnalysisStrategy = new SubmissionGroupsAnalysisCalculationStrategy();
            return AnalysisStrategy.highOutlierEachCriteria(this); //can use names to retrieve assignment if necessary fo rany features
        }
        public Dictionary<string, string> getLowestAssignmentInEachCriteria()
        {
            AnalysisStrategy = new SubmissionGroupsAnalysisCalculationStrategy();
            return AnalysisStrategy.lowOutlierEachCriteria(this);//can use names to retrieve assignment if necessary fo rany features
        }

        public Dictionary<string, double> getAverageOfAveragesStudent()
        {
            AnalysisStrategy = new GroupAnalysisCalculationStrategy();
            return AnalysisStrategy.calcAvgOfAvgs(this);
        }
        public Dictionary<string, double> getAverageOfAveragesSubmission()
        {
            AnalysisStrategy = new SubmissionGroupsAnalysisCalculationStrategy();
            return AnalysisStrategy.calcAvgOfAvgs(this);
        }

    }
}