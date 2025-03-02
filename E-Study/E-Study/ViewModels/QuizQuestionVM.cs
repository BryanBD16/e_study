using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using E_Study.Models;

namespace E_Study.ViewModels
{
    public class QuizQuestionVM
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int CourseId { get; set; }
        public QuizQuestionVM(Question question)
        {
            Id = question.Id;
            Text = question.Text;
            CourseId = question.CourseId;
        }
    }
}
