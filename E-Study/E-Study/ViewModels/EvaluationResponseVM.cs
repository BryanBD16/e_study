namespace E_Study.ViewModels
{
    public class EvaluationResponseVM
    {
        public int CourseId { get; set; }
        public List<EvaluationAnswerVM> Answers { get; set; }
        public EvaluationResponseVM(int courseId, List<EvaluationAnswerVM> answers)
        {
            CourseId = courseId;
            Answers = answers;
        }
        public EvaluationResponseVM()
        {
            
        }
    }
}
