using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData
            (
                new Employee
                {
                    Id = new Guid("bb08330a-9919-4634-b6e6-736298201ec7"),
                    Name = "Sam Raiden",
                    Age = 26,
                    Position = "Software developer",
                    CompanyId = new Guid("f61e67e9-1ae0-45d7-9f2f-a314ecedcd8b")
                },
                new Employee
                {
                    Id = new Guid("7ef7a9ca-0427-4e14-bac8-8ea5d73f2794"),
                    Name = "James Miller",
                    Age = 30,
                    Position = "Software Developer",
                    CompanyId = new Guid("f61e67e9-1ae0-45d7-9f2f-a314ecedcd8b")
                },
                new Employee
                {
                    Id = new Guid("54e9e7af-772d-49a1-9a8a-b0b3cc793cdc"),
                    Name = "Bob Martin",
                    Age = 35,
                    Position = "Administrator",
                    CompanyId = new Guid("0f434717-38fa-4024-ae67-ddf577797b7c")
                }
            );
        }
    }
}