﻿using StudentManagement.Shared.Models;

namespace StudentManagement.Client.Repository
{
    public interface ISystemCodeDetailRepository
    {
        Task<SystemCodeDetail> AddAsync(SystemCodeDetail mod);

        Task<SystemCodeDetail> UpdateAsync(SystemCodeDetail mod);

        Task<SystemCodeDetail> DeleteAsync(int id);

        Task<List<SystemCodeDetail>> GetAllAsync();

        Task<SystemCodeDetail> GetByIdAsync(int id);

        Task<List<SystemCodeDetail>> GetByCodeAsync(string code);
        
    }
}
