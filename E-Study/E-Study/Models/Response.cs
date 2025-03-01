using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace E_Study.Models
{
    public class Response
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Question")]
        [Required]
        public int QuestionId { get; set; }
        [ValidateNever]
        public Question Question { get; set; }

        [ForeignKey("SelectedAnswer")]
        [Required(ErrorMessage = "You have to select an answer")]
        public int SelectedAnswerId { get; set; }
        [ValidateNever]
        public AnswerOption SelectedAnswer { get; set; }

    }
}
