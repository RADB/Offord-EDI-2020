using EDI.ApplicationCore.Entities;
using EDI.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EDI.Infrastructure.Interfaces
{
    public interface IAsyncIdentityRepository
    {
        IReadOnlyList<ApplicationUser> ListAllUsers();
        IReadOnlyList<IdentityRole> ListAllRoles();

        int GetDuplicateCount(string email, string phonenumber);
        int GetDuplicateCount(string email);
        int GetOtherDuplicateCount(string email, string accountId);

        Task<ApplicationUser> GetByIdAsync(string id);

        Task DeleteAsync(ApplicationUser entity);
        Task UpdateAsync(ApplicationUser entity);
        Task<IdentityRole> GetRoleByIdAsync(string id);
        string GetRoleIDByname(string name);
        Task DeleteRoleAsync(IdentityRole entity);
        Task UpdateRoleAsync(IdentityRole entity);
        int GetDuplicateRoleCount(string name);
        int GetDuplicateRoleCount(string name, string roleid);
    }
}
