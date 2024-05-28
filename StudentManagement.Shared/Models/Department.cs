using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Shared.Models
{
     public class Department :UserCreateActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

    }
}
