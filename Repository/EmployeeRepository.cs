using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using Repository.Extension


namespace Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateEmployeeForCompany(Guid companyId, Employee employee)
        {
            employee.CompanyId = companyId;
            Create(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            Delete(employee);
        }

        public async Task<Employee> GetEmployeeAsync(Guid companyId, Guid id, bool trackChanges) => await
            GetByCondition(m => m.CompanyId.Equals(companyId) && m.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public async Task<PagedList<Employee>> GetEmployeesAsync(Guid companyId, EmployeeParameters employeeParameters, bool trackChanges)
        {
            var employees = await

             GetByCondition(e => e.CompanyId.Equals(companyId), trackChanges)
             .FilterEmployees(employeeParameters.MinAge, employeeParameters.MaxAge)
             .Search(employeeParameters.SearchTerm)
             .OrderBy(e => e.Name)
             .ToListAsync();
            return PagedList<Employee>
                .ToPageList(employees, employeeParameters.PageNumber, employeeParameters.PageSize);
        }
    }
}