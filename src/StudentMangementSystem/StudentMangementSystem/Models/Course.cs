
using System.ComponentModel.DataAnnotations;

namespace StudentMangementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string CourseCode { get; set; } = string.Empty;

        [Required]
        public string CourseName { get; set; } = string.Empty;

        [Range(1, 6)]
        public int Credit { get; set; }

        public string? Description { get; set; }
    }
}
