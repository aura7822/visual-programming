using System.ComponentModel.DataAnnotations;

namespace StudentApplication.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Course { get; set; } = string.Empty;

        public int Age { get; set; }
    }
}