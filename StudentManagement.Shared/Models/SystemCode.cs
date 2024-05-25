using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Shared.Models
{
    public class SystemCode
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        public string Description { get; set; }

    }
}
