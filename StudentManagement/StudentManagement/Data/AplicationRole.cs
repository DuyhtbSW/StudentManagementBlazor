
using Microsoft.AspNetCore.Identity;

namespace StudentManagement.Data
{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; }
        public string CreatedById { get; set; }
        public ApplicationUser CreatedBy { get; set; }
        public DateTime CreateOn { get; set; }
        public string ReviewedById { get; set; }
        public ApplicationUser ReviewedBy { get; set; }
    }
}
