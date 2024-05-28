using Microsoft.EntityFrameworkCore;
using StudentManagement.Client.Repository;
using StudentManagement.Data;
using StudentManagement.Shared.Models;

namespace StudentManagement.Services
{
    public class BookIssuranceRepository : IBookIssuranceRepository
    {
        private readonly ApplicationDbContext _context;

        public BookIssuranceRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<BookIssuance> AddAsync(BookIssuance mod)
        {
            mod.CreatedById = "Bao Duy";
            mod.CreatedOn = DateTime.Now;
            if (mod == null) return null;

            var newcountry = _context.BookIssuanceHistory.Add(mod).Entity;
            await _context.SaveChangesAsync();

            return newcountry;
        }

        public async Task<BookIssuance> DeleteAsync(int Id)
        {
            var data = await _context.BookIssuanceHistory.Where(x => x.Id == Id).FirstOrDefaultAsync();
            if (data == null) return null;

            _context.BookIssuanceHistory.Remove(data);
            await _context.SaveChangesAsync();

            return data;
        }

        public async Task<List<BookIssuance>> GetAllAsync()
        {
            var data = await _context.BookIssuanceHistory
                .Include(x=>x.Class)
                .Include(x=> x.Student)
                .Include(x=>x.Book)
                .ToListAsync();

            return data;
        }

        public async Task<BookIssuance> GetByIdAsync(int Id)
        {
            var data = await _context.BookIssuanceHistory.Where(x => x.Id == Id).FirstOrDefaultAsync();
            if (data == null) return null;

            return data;
        }

        public async Task<BookIssuance> UpdateAsync(BookIssuance mod)
        {
            if (mod == null) return null;

            var data = _context.BookIssuanceHistory.Update(mod).Entity;
            await _context.SaveChangesAsync();

            return data;
        }
    }
}
