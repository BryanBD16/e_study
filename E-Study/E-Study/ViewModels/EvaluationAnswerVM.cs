using System.ComponentModel.DataAnnotations;

namespace E_Study.ViewModels
{
    public class EvaluationAnswerVM
    {
        public int QuestionId { get; set; }
        [Required(ErrorMessage = "You have to select an answer")]
        public int SelectedAnswerId { get; set; }
        public EvaluationAnswerVM(int questionId, int selectedAnswerId)
        {
            QuestionId = questionId;
            SelectedAnswerId = selectedAnswerId;
        }
        public EvaluationAnswerVM()
        {
            
        }
    }
}
