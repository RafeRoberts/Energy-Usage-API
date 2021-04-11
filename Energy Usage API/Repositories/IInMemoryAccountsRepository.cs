using Energy_Usage_API.Models;
using System.Collections.Generic;

namespace Energy_Usage_API.Reposities
{
    public interface IInMemoryAccountsRepository
    {
        Account GetAccount(int id);
        IEnumerable<Account> GetAccounts();
        void CreateAccount(Account account);
        void UpdateAccount(Account account);
    }
}