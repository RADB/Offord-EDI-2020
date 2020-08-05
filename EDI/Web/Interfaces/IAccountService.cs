using EDI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    public interface IAccountService
    {
        Task DeleteAccountAsync(string Id);

        Task UpdateAccountAsync(AccountItemViewModel account);

        Task CreateAccountAsync(AccountItemViewModel account);

        Task<AccountItemViewModel> GetAccountItem(string accountId);

        int GetDuplicateCount(string email);
        int GetOtherDuplicateCount(string email, string accountId);
        Task UnlockAccountAsync(string Id);
        Task LockAccountAsync(string Id);
        Task<IEnumerable<SelectListItem>> GetRoles();
        Task<IEnumerable<SelectListItem>> GetUsers();
        Task<AccountItemViewModel> GetProfile();
        Task CreateRoleAsync(RoleItemViewModel role);
        Task DeleteRoleAsync(string Id);
        int GetDuplicateRoleCount(string name);
        int GetDuplicateRoleCount(string name, string roleid);
        Task UpdateRoleAsync(RoleItemViewModel role);
        Task<RoleItemViewModel> GetRoleItem(string roleid);
    }
}
