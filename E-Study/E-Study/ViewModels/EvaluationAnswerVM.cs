namespace E_Study.ViewModels
{
    public class EvaluationAnswerVM
    {
        public int QuestionId { get; set; }
        public int SelectedAnswerId { get; set; }
        public EvaluationAnswerVM(int questionId, int selectedAnswerId)
        {
            QuestionId = questionId;
            SelectedAnswerId = selectedAnswerId;
        }
    }
}
