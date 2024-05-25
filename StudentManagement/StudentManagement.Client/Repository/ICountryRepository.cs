using StudentManagement.Shared.Models;

namespace StudentManagement.Client.Repository
{
    public interface ICountryRepository
    {
       
            Task<Country> AddAsync(Country mod);
            Task<Country> UpdateAsync(Country mod);
            Task<Country> DeleteAsync(int Id);
            Task<List<Country>> GetAllAsync();
            Task<Country> GetByIdAsync(int Id);


        
    }
}
