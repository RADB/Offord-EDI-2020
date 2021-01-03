using EDI.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using EDI.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDI.Infrastructure.Identity;
using EDI.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace EDI.Infrastructure.Data
{
    /// <summary>
    /// "There's some repetition here - couldn't we have some the sync methods call the async?"
    /// https://blogs.msdn.microsoft.com/pfxteam/2012/04/13/should-i-expose-synchronous-wrappers-for-asynchronous-methods/
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EfIdentityRepository: IAsyncIdentityRepository
    {
        protected readonly ServiceContext _dbContext;
        protected readonly AppIdentityDbContext _identityContext;

        public EfIdentityRepository(ServiceContext dbContext, AppIdentityDbContext identityContext)
        {
            _dbContext = dbContext;
            _identityContext = identityContext;
        }

        public virtual async Task<EDIApplicationUser> GetByIdAsync(string id)
        {
            return await _identityContext.Set<EDIApplicationUser>().FindAsync(id);
        }

        public virtual async Task<IdentityRole> GetRoleByIdAsync(string id)
        {
            return await _identityContext.Set<IdentityRole>().FindAsync(id);
        }

        public async Task DeleteAsync(EDIApplicationUser entity)
        {
            _identityContext.Set<EDIApplicationUser>().Remove(entity);
            await _identityContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(EDIApplicationUser entity)
        {
            _identityContext.Entry(entity).State = EntityState.Modified;
            await _identityContext.SaveChangesAsync();
        }

        public async Task DeleteRoleAsync(IdentityRole entity)
        {
            _identityContext.Set<IdentityRole>().Remove(entity);
            await _identityContext.SaveChangesAsync();
        }

        public async Task UpdateRoleAsync(IdentityRole entity)
        {
            _identityContext.Entry(entity).State = EntityState.Modified;
            await _identityContext.SaveChangesAsync();
        }

        public IReadOnlyList<EDIApplicationUser> ListAllUsers()
        {
            return _identityContext.Set<EDIApplicationUser>().ToList();
        }

        public IReadOnlyList<IdentityRole> ListAllRoles()
        {
            return _identityContext.Set<IdentityRole>().ToList();
        }

        public int GetDuplicateCount(string email, string phonenumber)
        {
            var fp = (from p in _identityContext.Users where p.UserName == email && p.PhoneNumber == phonenumber select p);

            if (fp != null && fp.Count() > 0)
                return fp.Count();
            else
                return 0;
        }
        public int GetDuplicateCount(string email)
        {
            var fp = (from p in _identityContext.Users where p.UserName == email select p);

            if (fp != null && fp.Count() > 0)
                return fp.Count();
            else
                return 0;
        }

        public int GetOtherDuplicateCount(string email, string accountId)
        {
            var fp = (from p in _identityContext.Users where p.UserName == email && p.Id != accountId select p);

            if (fp != null && fp.Count() > 0)
                return fp.Count();
            else
                return 0;
        }
        public int GetDuplicateRoleCount(string name)
        {
            var fp = (from p in _identityContext.Roles where p.Name == name select p);

            if (fp != null && fp.Count() > 0)
                return fp.Count();
            else
                return 0;
        }

        public int GetDuplicateRoleCount(string name, string roleid)
        {
            var fp = (from p in _identityContext.Roles where p.Name == name && p.Id != roleid select p);

            if (fp != null && fp.Count() > 0)
                return fp.Count();
            else
                return 0;
        }

        public string GetRoleIDByname(string name)
        {
            var fp = (from p in _identityContext.Roles where p.Name == name select p);

            if (fp != null && fp.Count() > 0)
                return fp.First().Id;
            else
                return string.Empty;
        }
    }
}
