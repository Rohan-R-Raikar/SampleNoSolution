﻿using SampleNo.Entity;

namespace SampleNo.Repositories.IRepositories
{
    public interface IApplicationUserRepository
    {
        Task<IEnumerable<ApplicationUser>> GetAllUsersAsync();
        Task<ApplicationUser> GetByIdAsync(Guid id);
        Task<ApplicationUser> UpdateUserAsync(ApplicationUser user);
        Task<ApplicationUser> SoftDeleteUserAsync(Guid id, string deletedBy);
        Task<ApplicationUser> RestoreUserAsync(Guid id);
        Task<IEnumerable<ApplicationUser>> GetActiveUsersAsync();
        Task<IEnumerable<ApplicationUser>> GetDeletedUsersAsync();
    }
}
