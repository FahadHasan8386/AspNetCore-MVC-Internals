using System.ComponentModel.DataAnnotations;

namespace StudentMangementSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(100)]
        public string EmployeeName { get; set; }

        public double PerformanceScore { get; set; }
        public double LowestProjectRating { get; set; }

        public int TotalProjectsCompleted { get; set; }
    }
}
