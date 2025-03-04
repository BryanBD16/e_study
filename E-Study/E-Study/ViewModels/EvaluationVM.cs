using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace E_Study.ViewModels
{
    public class EvaluationVM
    {
        public int CourseId { get; set; }
        [BindNever]
        public List<EvaluationQuestionVM> Questions { get; set; }
        public List<EvaluationAnswerVM> Answers { get; set; } = new();

        public EvaluationVM() { }

        public EvaluationVM(List<EvaluationQuestionVM> questions, int courseId)
        {
            Questions = questions;
            CourseId = courseId;
            Answers = questions.Select(q => new EvaluationAnswerVM { QuestionId = q.Id }).ToList();
        }
    }
}
