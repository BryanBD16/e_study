using E_Study.Models;
using System.ComponentModel.DataAnnotations;

namespace E_Study.ViewModels
{
    public class CourseMaterialsVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string YouTubeId { get; set; }

        public CourseMaterialsVM(Course course)
        {
            Id = course.Id;
            YouTubeId = course.YouTubeId;
            Title = course.Title;
        }
        public CourseMaterialsVM()
        {
            
        }
    }
}
