using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Entities.Models;

namespace Contracts
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);

        Company GetCompany(Guid companyId, bool trackChanges);

        void CreateCompany(Company company);

        IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackChanges);

        void DeleteCompany(Company company);
    }
}