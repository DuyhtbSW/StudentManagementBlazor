using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Shared.Models
{
    public   class BookIssuance : UserCreateActivity
    {
        public int Id { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }

        public DateTime? ReturnDate { get; set; }
        public int ClassId { get; set; }
        public SystemCodeDetail Class {  get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public string Notes { get; set; }
    }
}
