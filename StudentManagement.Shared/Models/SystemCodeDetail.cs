﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Shared.Models
{
    public class SystemCodeDetail
    {
        [Key]
        public int id { get; set; }

        public int SystemCodeId { get; set; }
        public SystemCode SystemCode { get; set; }
        public string Description { get; set; }
        public int? OrderNo { get; set; }
    }
}
