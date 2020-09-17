using EDI.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using EDI.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using EDI.Infrastructure.Identity;
using EDI.ApplicationCore.Extensions;

namespace EDI.Infrastructure.Data
{
    /// <summary>
    /// "There's some repetition here - couldn't we have some the sync methods call the async?"
    /// https://blogs.msdn.microsoft.com/pfxteam/2012/04/13/should-i-expose-synchronous-wrappers-for-asynchronous-methods/
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EfRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        protected readonly ServiceContext _dbContext;
        protected readonly AppIdentityDbContext _identityContext;

        public EfRepository(ServiceContext dbContext, AppIdentityDbContext identityContext)
        {
            _dbContext = dbContext;
            _identityContext = identityContext;
        }
        
        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
        
        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public async Task<IReadOnlyList<T>> ListAllViewAsync()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ServiceContext>();
            optionsBuilder.UseSqlServer(ConnectionStrings.ServiceConnection());
            using (ServiceContext servicecontext = new ServiceContext(optionsBuilder.Options))
            {
                return await servicecontext.Set<T>().ToListAsync();
            }
        }

        public async Task<IReadOnlyList<T>> ListViewAsync(ISpecification<T> spec)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ServiceContext>();
            optionsBuilder.UseSqlServer(ConnectionStrings.ServiceConnection());
            using (ServiceContext servicecontext = new ServiceContext(optionsBuilder.Options))
            {
                return await SpecificationEvaluator<T>.GetQuery(servicecontext.Set<T>().AsQueryable(), spec).ToListAsync();
            }
        }

        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

        public async Task<int> CountViewAsync(ISpecification<T> spec)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ServiceContext>();
            optionsBuilder.UseSqlServer(ConnectionStrings.ServiceConnection());
            using (ServiceContext servicecontext = new ServiceContext(optionsBuilder.Options))
            {
                return await SpecificationEvaluator<T>.GetQuery(servicecontext.Set<T>().AsQueryable(), spec).CountAsync();
            }
        }

        public async Task<T> AddAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }
        
        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        
        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
        
        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_dbContext.Set<T>().AsQueryable(), spec);
        }

        public DateDimension GetDateDimension(DateTime date)
        {
            var datedimension = (from p in _dbContext.DateDimension select p).Where(p => p.Date == date).FirstOrDefault();

            return datedimension;
        }

        public IReadOnlyList<Site> ListAllSites()
        {
            return _dbContext.Set<Site>().ToList();
        }

        public IReadOnlyList<Coordinator> ListAllCoordinators()
        {
            return _dbContext.Set<Coordinator>().ToList();
        }

        public IReadOnlyList<Year> ListAllYears()
        {
            return _dbContext.Set<Year>().ToList();
        }

        public IReadOnlyList<Gender> ListAllGenders()
        {
            return _dbContext.Set<Gender>().ToList();
        }

        public IReadOnlyList<School> ListAllSchools()
        {
            return _dbContext.Set<School>().ToList();
        }

        public IReadOnlyList<Teacher> ListAllTeachers()
        {
            return _dbContext.Set<Teacher>().ToList();
        }


        public async Task DeleteAllFileImports()
        {
            await _dbContext.Database.ExecuteSqlCommandAsync("TRUNCATE TABLE [Staging].[FileImports]");
        }

        public async Task ReseedFileImports()
        {
            await _dbContext.Database.ExecuteSqlCommandAsync("DBCC CHECKIDENT ([staging.FileImports], RESEED, 0)");
        }
    }
}
