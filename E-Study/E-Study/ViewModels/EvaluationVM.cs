namespace E_Study.ViewModels
{
    public class EvaluationVM
    {
        public int CourseId { get; set; }
        public List<EvaluationQuestionVM> Questions { get; set; }

        public EvaluationVM(List<EvaluationQuestionVM> questions, int courseId)
        {
            Questions = questions;
            CourseId = courseId;

        }
    }
}
