using Microsoft.EntityFrameworkCore;
using StudentManagement.Data;
using StudentManagement.Services;
using StudentManagement.Shared.Models;
using StudentManagement.Shared.StudentRepository;

namespace StudentManagement.Services
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext db;

        public StudentRepository(ApplicationDbContext context) { 
        db = context;
        }
        public async Task<Student> AddStudentAsync(Student student)
        {
            if (student == null) throw new ArgumentNullException();
            var newstudent = db.Add(student).Entity;
            await db.SaveChangesAsync();
            return newstudent;
        }

        public async Task<Student?> DeleteStudentAsync(int studentId)
        {
           var student = await db.Students.Where(s => s.Id == studentId).FirstOrDefaultAsync();
            if (student == null)
                return null;
            db.Students.Remove(student);
            await db.SaveChangesAsync();
            return student;
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            var students = await db.Students.ToListAsync();
            return students;
        }

        public Task<Student> GetStudentByIdAsync(int studentId)
        {
            throw new NotImplementedException();
        }

        public Task<Student> UpdateStudentAsync(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
