using E_Study.Models;

namespace E_Study.ViewModels
{
    public class ResultVM
    {
        public DateTime ResultTime { get; set; }
        public int GoodAnswer { get; set; }
        public int BadAnswer { get; set; }
        public int QuestionCount { get; set; }
        public ResultVM()
        {
            
        }
        public ResultVM(CourseResult result)
        {
            ResultTime = result.ResultTime;
            GoodAnswer = result.Answers.Where(a => a.SelectedAnswerId == a.Question.AnswerOptions.Where(ao => ao.IsCorrect).FirstOrDefault().Id).Count();
            QuestionCount = result.Course.Questions.Count();
            BadAnswer = QuestionCount - GoodAnswer;
        }
    }
}
