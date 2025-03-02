using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace E_Study.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CourseResult")]
        [Required]
        public int CourseResultId { get; set; }
        [ValidateNever]
        public CourseResult CourseResult { get; set; }

        [Required]
        public int QuestionId { get; set; }
        [ValidateNever]
        public Question Question { get; set; }

        [Required(ErrorMessage = "You have to select an answer")]
        public int SelectedAnswerId { get; set; }
        [ValidateNever]
        public AnswerOption SelectedAnswer { get; set; }

    }
}
