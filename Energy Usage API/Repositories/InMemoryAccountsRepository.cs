using Energy_Usage_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Energy_Usage_API.Reposities
{

    public class InMemoryAccountsRepository
    {


        private readonly List<Account> accounts = new()
        {
            new Account { Id = Guid.NewGuid(), AccountId = 2344, FirstName = "Tommy", LastName = "Test" },
            new Account { Id = Guid.NewGuid(), AccountId = 2233, FirstName = "Barry", LastName = "Test" },
            new Account { Id = Guid.NewGuid(), AccountId = 8766, FirstName = "Sally", LastName = "Test" }
        };

        public IEnumerable<Account> GetAccounts()
        {
            return accounts;
        }

        public Account GetAccount(Guid id)
        {
            return accounts.Where(account => account.Id == id).SingleOrDefault();
        }
    }
}