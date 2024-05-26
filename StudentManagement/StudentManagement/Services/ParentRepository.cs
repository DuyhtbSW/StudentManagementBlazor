using Microsoft.EntityFrameworkCore;
using StudentManagement.Client.Repository;
using StudentManagement.Data;
using StudentManagement.Shared.Models;

namespace StudentManagement.Services
{
    public class ParentRepository : IParentRepository
    {
        private readonly ApplicationDbContext _context;

        public ParentRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<Parent> AddAsync(Parent mod)
        {
            if (mod == null) return null;

            var newcountry = _context.Parents.Add(mod).Entity;
            await _context.SaveChangesAsync();

            return newcountry;
        }

        public async Task<Parent> DeleteAsync(int Id)
        {
            var data = await _context.Parents.Where(x => x.Id == Id).FirstOrDefaultAsync();
            if (data == null) return null;

            _context.Parents.Remove(data);
            await _context.SaveChangesAsync();

            return data;
        }

        public      async    Task<List<Parent>> GetAllAsync()
        {
            var data = await _context.Parents
                .Include(x=>x.Student)
                .ToListAsync();

            return data;
        }

        public async Task<Parent> GetByIdAsync(int Id)
        {
            var data = await _context.Parents.Where(x => x.Id == Id).FirstOrDefaultAsync();
            if (data == null) return null;

            return data;
        }

        public async Task<Parent> UpdateAsync(Parent mod)
        {
            if (mod == null) return null;

            var data = _context.Parents.Update(mod).Entity;
            await _context.SaveChangesAsync();

            return data;
        }
    }
}
