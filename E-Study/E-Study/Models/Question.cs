using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace E_Study.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "You have to write a question")]
        [StringLength(500, ErrorMessage = "The question cannot be longer than 500 caracters")]
        public string Text { get; set; }

        [ForeignKey("Course")]
        [Required]
        public int CourseId { get; set; }

        [ValidateNever]
        public Course Course { get; set; }

        [ValidateNever]
        public ICollection<AnswerOption> AnswerOptions { get; set; }


    }
}
