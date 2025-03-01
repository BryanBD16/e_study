using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace E_Study.Models
{
    public class AnswerOption
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "You have to write an answer option")]
        [StringLength(100, ErrorMessage = "The answer option cannot be longer than 100 caracters")]
        public string Text { get; set; }

        [Required(ErrorMessage = "You have to specify if the answer is correct or not")]
        public bool IsCorrect { get; set; }

        [ForeignKey("Question")]
        [Required]
        public int QuestionId { get; set; }
        [ValidateNever]
        public Question Question { get; set; }
    }
}
