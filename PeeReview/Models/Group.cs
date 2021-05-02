using System.Collections.Generic;

namespace PeeReview.Models
{
    public class Group
    {
        public string name { get; private set; }
        private int uniqueCode;
        private double chemstryPoint; //double was favoured for smoother usage 
        private double averageEvaluation; // Will become multiple for each category
        public Evaluation GroupEvaluation { get; private set; }

        public List<Student> students { get; private set; }
        public List<Project> projects{ get; private set; }
        public List<Grader> graders{ get; private set; }
        public List<Assignment> assignments{ get; private set; }



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

        public double calcChem()
        {
            return chemstryPoint;//TODO
        }

        public double getChemistry()
        {
            return chemstryPoint;
        }

        public double getEval()
        {
            return averageEvaluation;
        }

        public void updateEval(int score, double chem)
        {
             //TODO
        }
    }
}