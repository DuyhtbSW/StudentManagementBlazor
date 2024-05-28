using Microsoft.EntityFrameworkCore;
using StudentManagement.Client.Repository;
using StudentManagement.Data;
using StudentManagement.Shared.Models;

namespace StudentManagement.Services
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _context;

        public DepartmentRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<Department> AddAsync(Department mod)
        {
            mod.CreatedById = "Bao Duy";
            mod.CreatedOn = DateTime.Now;
            if (mod == null) return null;

            var data = _context.Departments.Add(mod).Entity;
            await _context.SaveChangesAsync();

            return data;
        }

        public async Task<Department> DeleteAsync(int id)
        {
            var data = await _context.Departments.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (data == null) return null;

            _context.Departments.Remove(data);
            await _context.SaveChangesAsync();

            return data;
        }

        public async Task<List<Department>> GetAllAsync()
        {
            var data = await _context.Departments.ToListAsync();

            return data;
        }

        public async Task<Department> GetByIdAsync(int id)
        {
            var data = await _context.Departments.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (data == null) return null;

            return data;
        }

        public async Task<Department> UpdateAsync(Department mod)
        {
            if (mod == null) return null;

            var data = _context.Departments.Update(mod).Entity;
            await _context.SaveChangesAsync();

            return data;
        }
    }
}
