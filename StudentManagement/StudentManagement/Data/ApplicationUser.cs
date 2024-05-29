

using Microsoft.AspNetCore.Identity;
using StudentManagement.Shared.Models;

namespace StudentManagement.Data
{
    public class ApplicationUser :IdentityUser
    {
        public string FirstName { get; set; }
        public string MiddeName { get; set; }
        public string LastName { get; set; }
        public string Photo {  get; set; }
        public int GenderId { get; set; }
        public SystemCodeDetail Gender { get; set; }
        public string FullName => $"{FirstName}  {MiddeName}{LastName}";
        public bool IsActive { get; set; }
        public DateTime LastActivityDate { get; set; }
        public DateTime DeactivatedOn { get; set; }
        public string RoleId { get; set; }
        public IdentityRole Role { get; set; }
    }
}
