using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Energy_Usage_API.Models
{
    public record Account
    {
        public Guid Id { get; init; }
        public int AccountId { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }
}
