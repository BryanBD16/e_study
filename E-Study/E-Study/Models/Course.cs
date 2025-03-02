using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace E_Study.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The title is mendatory")]
        [StringLength(100, ErrorMessage = "The title cannot be longer than 100 caracters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The description is mendatory")]
        [StringLength(500, ErrorMessage = "The description cannot be longer than 500 caracters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The youtubeId is required")]
        public string YouTubeId { get; set; }

        [ValidateNever]
        public ICollection<Question> Questions { get; set; }

        [ValidateNever]
        public ICollection<CourseResult> CourseResults { get; set; }
    }
}
