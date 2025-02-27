﻿using EDI.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EDI.ApplicationCore.Interfaces
{
    public interface IAsyncRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAllViewAsync();
        Task<IReadOnlyList<T>> ListViewAsync(ISpecification<T> spec);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<int> CountAsync(ISpecification<T> spec);
        Task<int> CountViewAsync(ISpecification<T> spec);
        DateDimension GetDateDimension(DateTime date);
        IReadOnlyList<Site> ListAllSites();
        IReadOnlyList<Coordinator> ListAllCoordinators();
        IReadOnlyList<Year> ListAllYears();
        IReadOnlyList<Gender> ListAllGenders();
        IReadOnlyList<School> ListAllSchools();
        IReadOnlyList<Teacher> ListAllTeachers();
        IReadOnlyList<FileImport> ListImportedData();
        IReadOnlyList<InputType> ListAllInputTypes();
        IReadOnlyList<Orientation> ListAllOrientations();
        IReadOnlyList<LookupSet> ListAllLookups();
        Task DeleteAllFileImports();
        Task ReseedFileImports();
    }
}
