using System.Collections.Generic;

namespace PeeReview.Models
{
    public class Graph //Late stage implementation
    //This is added now to show how the graphs would have been created, and the strategies to be used
    {
        public Dictionary<string, double> AverageGraphedData { get; private set; }
        public Dictionary<string, string> HighOutliers { get; private set; }
        public Dictionary<string, string> LowOutliers { get; private set; }
        public Graph(Group group, AnalysisCalculationStrategy analysisStrategy)
        {
            AverageGraphedData = analysisStrategy.calcAvgOfAvgs(group);
            HighOutliers = analysisStrategy.highOutlierEachCriteria(group);
            LowOutliers = analysisStrategy.lowOutlierEachCriteria(group);
        }

    }
}