using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public abstract class CompanyForManipulationDto
    {
        [Required]
        [StringLength(50, ErrorMessage = "Name field can not be more than 50 characters")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Address field can not be more than 100 characters")]
        public string Address { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Country field can not be more than 100 characters")]
        public string Country { get; set; }

        public IEnumerable<EmployeeForCreationDto> Employees { get; set; }
    }
}