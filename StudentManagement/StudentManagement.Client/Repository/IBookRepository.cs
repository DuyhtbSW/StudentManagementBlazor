using StudentManagement.Shared.Models;

namespace StudentManagement.Client.Repository
{
    public interface IBookRepository
    {
        Task<Book> AddAsync(Book mod);

        Task<Book> UpdateAsync(Book mod);

        Task<Book> DeleteAsync(int id);

        Task<List<Book>> GetAllAsync();

        Task<Book> GetByIdAsync(int id);
    }
}
