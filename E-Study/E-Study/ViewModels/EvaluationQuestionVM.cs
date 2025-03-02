using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using E_Study.Models;

namespace E_Study.ViewModels
{
    public class EvaluationQuestionVM
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<AnswerOption> AnswerOptions { get; set; }
        public EvaluationQuestionVM(Question question)
        {
            Id = question.Id;
            Text = question.Text;
            AnswerOptions = question.AnswerOptions.ToList();
        }
    }
}
