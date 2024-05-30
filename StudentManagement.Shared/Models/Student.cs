using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Shared.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Registration No is required.")]
        public string RegistrationNo { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(50, ErrorMessage = "First Name cannot be longer than 50 characters.")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "Middle Name cannot be longer than 50 characters.")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(50, ErrorMessage = "Last Name cannot be longer than 50 characters.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        [Phone(ErrorMessage = "Invalid Phone Number.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        public int CountryId { get; set; }

        public Country Country { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public int GenderId { get; set; }

        public SystemCodeDetail Gender { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        [DateRange(100, 100, ErrorMessage = "Date of Birth wrong.")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public string FullName => $"{FirstName} {MiddleName} {LastName}";
    }
}
