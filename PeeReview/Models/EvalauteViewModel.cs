namespace PeeReview.Models
{
    public class EvalauteViewModel
    {
        public EvalauteViewModel(Evaluation eval, Group gr)
        {
            evaluation = eval;
            group = gr;
        }

        public Evaluation evaluation { get; set; }
        public Group group { get; set; }
    }
}