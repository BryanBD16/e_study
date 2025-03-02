using E_Study.Models;

namespace E_Study.ViewModels
{
    public class CourseDisplayVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public CourseDisplayVM(Course course)
        {
            Id = course.Id;
            Title = course.Title;
        }
        public CourseDisplayVM() { }
    }
}
