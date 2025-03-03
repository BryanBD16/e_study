using E_Study.Models;
using System.ComponentModel;

namespace E_Study.ViewModels
{
    public class CourseDisplayVM
    {
        public int Id { get; set; }
        [DisplayName("Course Title")]
        public string Title { get; set; }
        public CourseDisplayVM(Course course)
        {
            Id = course.Id;
            Title = course.Title;
        }
        public CourseDisplayVM() { }
    }
}
