using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateCompany(Company company) => Create(company);

        public IEnumerable<Company> GetAllCompanies(bool trackChanges) =>
            GetAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

        public IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackChanges) => GetByCondition(m => ids.Contains(m.Id), trackChanges).ToList();

        public Company GetCompany(Guid companyId, bool trackChanges) => GetByCondition(c => c.Id.Equals(companyId), trackChanges).SingleOrDefault();
    }
}