using E_Study.Models;
using System.ComponentModel.DataAnnotations;

namespace E_Study.ViewModels
{
    public class CourseDetailsVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public CourseDetailsVM(Course course)
        {
            Id = course.Id;
            Title = course.Title;
            Description = course.Description;
        }
        public CourseDetailsVM() { }
    }
}
