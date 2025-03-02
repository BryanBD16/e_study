using E_Study.Models;

namespace E_Study.ViewModels
{
    public class QuestionVM
    {
        public int CourseId { get; set; }
        public string Text { get; set; }
        public List<AnswerOptionVM> AnswerOptions { get; set; }
    }
}
