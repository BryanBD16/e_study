using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Study.Models
{
    public class CourseResult
    {
        [Key]
        public int Id { get; set; }

        public DateTime ResultTime { get; set; } = DateTime.Now;

        [ForeignKey("Course")]
        [Required]
        public int CourseId { get; set; }

        [ValidateNever]
        public Course Course { get; set; }

        [ValidateNever]
        public ICollection<Answer> Answers { get; set; } = new List<Answer>();

    }
}
