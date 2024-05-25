using Microsoft.EntityFrameworkCore;
using StudentManagement.Client.Repository;
using StudentManagement.Data;
using StudentManagement.Shared.Models;

namespace StudentManagement.Services
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ApplicationDbContext _context;

        public CountryRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<Country> AddAsync(Country mod)
        {
            if (mod == null) return null;

            var newcountry = _context.Countries.Add(mod).Entity;
            await _context.SaveChangesAsync();

            return newcountry;
        }

        public async Task<Country> DeleteAsync(int Id)
        {
            var country = await _context.Countries.Where(x => x.Id == Id).FirstOrDefaultAsync();
            if (country == null) return null;

            _context.Countries.Remove(country);
            await _context.SaveChangesAsync();

            return country;
        }

        public  async Task<List<Country>> GetAllAsync()
        {
            var countries = await _context.Countries.ToListAsync();

            return countries;
        }

        public async Task<Country> GetByIdAsync(int Id)
        {
            var singlecountry = await _context.Countries.Where(x => x.Id == Id).FirstOrDefaultAsync();
            if (singlecountry == null) return null;

            return singlecountry;
        }

        public async Task<Country> UpdateAsync(Country mod)
        {
            if (mod == null) return null;


            var country = _context.Countries.Update(mod).Entity;
            await _context.SaveChangesAsync();

            return country;
        }
    }
}
