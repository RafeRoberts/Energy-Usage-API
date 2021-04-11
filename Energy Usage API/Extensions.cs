using Energy_Usage_API.Dtos;
using Energy_Usage_API.Models;

namespace Energy_Usage_API
{
    public static class Extensions
    {
        public static AccountDto AsDto(this Account account)
        {
            return new AccountDto
            {
                Id = account.Id,
                AccountId = account.AccountId,
                FirstName = account.FirstName,
                LastName = account.LastName
            };
        }
    }
}