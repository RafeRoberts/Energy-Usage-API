using Energy_Usage_API.Dtos;
using Energy_Usage_API.Reposities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Energy_Usage_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
       
        private readonly IInMemoryAccountsRepository repository;

        public AccountsController(IInMemoryAccountsRepository repository)
        {
            this.repository = repository;
        }
        // GET: api/<AccountsController>
        [HttpGet]
        public IEnumerable<AccountDto> GetAccounts()
        {
            var accounts = repository.GetAccounts().Select( account => account.AsDto());
            return accounts;
        }

        // GET api/<AccountsController>/{AccountId}
        [HttpGet("{AccountId}")]
        public ActionResult<AccountDto> Get(int AccountId)
        {
            var account = repository.GetAccount(AccountId);
            if (account is null)
            {
                return NotFound();
            }
            return account.AsDto();
        }

        // POST api/<AccountsController>
        [HttpPost]
        public ActionResult<AccountDto> CreateAccount(CreateAccountDto accountDto)
        {
            Models.Account account = new()
            {
                Id = Guid.NewGuid(),
                AccountId = accountDto.AccountId,
                FirstName = accountDto.FirstName,
                LastName = accountDto.LastName
            };
            repository.CreateAccount(account);

            return CreatedAtAction(nameof(GetAccounts), new { id = account.Id }, account.AsDto());
        }

        // PUT api/<AccountsController>/5
        [HttpPut("{id}")]
        public ActionResult UpdateAccount(int id, UpdateAccountDto accountDto)
        {
            var existingAccount = repository.GetAccount(id);
            if (existingAccount is null)
            {
                return NotFound();
            }

            Models.Account updatedAccount = existingAccount with
            {
                AccountId = accountDto.AccountId,
                FirstName = accountDto.FirstName,
                LastName = accountDto.LastName
            };

            repository.UpdateAccount(updatedAccount);

            return NoContent();
        }
       
            

        // DELETE api/<AccountsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
