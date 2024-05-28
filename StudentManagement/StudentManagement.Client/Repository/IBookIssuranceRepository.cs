using StudentManagement.Shared.Models;

namespace StudentManagement.Client.Repository
{
    public interface IBookIssuranceRepository
    {
        Task<BookIssuance> AddAsync(BookIssuance mod);
        Task<BookIssuance> UpdateAsync(BookIssuance mod);
        Task<BookIssuance> DeleteAsync(int Id);
        Task<List<BookIssuance>> GetAllAsync();
        Task<BookIssuance> GetByIdAsync(int Id);
    }
}
