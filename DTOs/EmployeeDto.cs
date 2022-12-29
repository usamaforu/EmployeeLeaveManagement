using DomainEntity.Enum;
using DomainEntity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class EmployeeDto : BaseDto
    {
        [Required]
        public string FirstName { get; set; } = String.Empty;
        [Required]

        public string LastName { get; set; } = String.Empty;
        [EmailAddress]
        public string Email { get; set; } = String.Empty;
        [Required]

        public DateTime DateOfBrith { get; set; }
        [Required]
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public List<Leave> leaves { get; set; } = new();

    }
}
