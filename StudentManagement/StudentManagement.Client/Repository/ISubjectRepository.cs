﻿using StudentManagement.Shared.Models;

namespace StudentManagement.Client.Repository
{
    public interface ISubjectRepository
    {
        Task<Subject> AddAsync(Subject mod);

        Task<Subject> UpdateAsync(Subject mod);

        Task<Subject> DeleteAsync(int id);

        Task<List<Subject>> GetAllAsync();

        Task<Subject> GetByIdAsync(int id);
    }
}
