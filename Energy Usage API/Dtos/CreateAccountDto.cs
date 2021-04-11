using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Energy_Usage_API.Dtos
{
    public record CreateAccountDto
    {
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Range(1,9999)]
        public int AccountId { get; init; }
        [System.ComponentModel.DataAnnotations.Required]
        public string FirstName { get; init; }
        [System.ComponentModel.DataAnnotations.Required]
        public string LastName { get; init; }
    }
}