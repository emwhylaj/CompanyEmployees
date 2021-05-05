using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData
            (
                new Company
                {
                    Id = new Guid("f61e67e9-1ae0-45d7-9f2f-a314ecedcd8b"),
                    Name = "IT_Solution Ltd",
                    Address = "583 Wall Dr. Gwynn Oak, MD 21207",
                    Country = "USA"
                },
                new Company
                {
                    Id = new Guid("0f434717-38fa-4024-ae67-ddf577797b7c"),
                    Name = "Admin Solutions Ltd",
                    Address = "312 Forest Avenue, BF 923",
                    Country = "USA"
                }

            );
        }
    }
}