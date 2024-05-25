using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Shared.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required ]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string? Phone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
