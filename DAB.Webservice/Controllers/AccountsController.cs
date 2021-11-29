using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DAB.Webservice.Data;
using DAB.Webservice.Models;
using Microsoft.Extensions.Logging;

namespace DAB.Webservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly DABWebserviceContext _context;
        private readonly ILogger<AccountsController> _logger;

        public AccountsController(DABWebserviceContext context, ILogger<AccountsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpPost("Authenticate")]
        public async Task<ActionResult<Account>> Authenticate([FromBody] AccountAuthentication accountAuthentication)
        {
            _logger.Log(LogLevel.Information, "Web API Accounts/Authenticate called");

            if (accountAuthentication == null || string.IsNullOrEmpty(accountAuthentication.Number) || string.IsNullOrEmpty(accountAuthentication.Pin))
                return Unauthorized();

            var account =
                await _context.Account
                .FirstOrDefaultAsync(m => m.Number == accountAuthentication.Number);

            if (account == null)
            {
                return NotFound();
            }
            else
            {
                if (account.Pin == accountAuthentication.Pin /*&& account.AuthenticationTries < 3*/)
                {
                    return account;
                }
                else
                {
                    // TODO : implement tries
                    //account.AuthenticationTries++;
                    //_context.SaveChanges();

                    return Unauthorized();
                }
            }
        }

        [HttpGet("GetAll")]
        // GET: Accounts
        public async Task<ActionResult<IEnumerable<Account>>> GetAll()
        {
            _logger.Log(LogLevel.Information, "Web API Accounts/GetAll called");

            var accounts = await _context.Account.ToListAsync();

            return accounts;
        }

        [HttpGet("GetAllNumbers")]
        // GET: Account numbers
        public async Task<ActionResult<IEnumerable<string>>> GetAllNumbers()
        {
            _logger.Log(LogLevel.Information, "Web API Accounts/GetAllNumbers called");

            List<string> accountNumbers =
                await _context.Account
                .Select(a => a.Number)
                .ToListAsync();

            return accountNumbers;
        }

        [HttpGet("Search/{stringToSearch}")]
        public async Task<ActionResult<IEnumerable<string>>> Search(string stringToSearch)
        {
            _logger.Log(LogLevel.Information, "Web API Accounts/Search called");

            List<string> accountNumbers =
                await _context.Account
                .Where(a => a.Number.Contains(stringToSearch))
                .Select(a => a.Number)
                .ToListAsync();

            return accountNumbers;
        }

        [HttpPost("Credit")]
        public async Task<ActionResult<Account>> Credit([FromBody] AccountTransaction accountTransaction)
        {
            _logger.Log(LogLevel.Information, "Web API Accounts/Credit called");

            if (string.IsNullOrEmpty(accountTransaction.AccountNumber))
                return NotFound();

            Account account =
                await _context.Account
                .FirstOrDefaultAsync(m => m.Number == accountTransaction.AccountNumber);

            if (account == null)
                return NotFound();

            if (accountTransaction.Amount < 0)
            {
                return Unauthorized();
            }
            else
            {
                account.Balance += accountTransaction.Amount;
                _context.SaveChanges();
            }

            return account;
        }

        [HttpPost("Debit")]
        public async Task<ActionResult<Account>> Debit([FromBody] AccountTransaction accountTransaction)
        {
            _logger.Log(LogLevel.Information, "Web API Accounts/Debit called");

            if (string.IsNullOrEmpty(accountTransaction.AccountNumber))
                return NotFound();

            Account account =
                await _context.Account
                .FirstOrDefaultAsync(m => m.Number == accountTransaction.AccountNumber);

            if (account == null)
                return NotFound();

            if (accountTransaction.Amount > account.Balance || accountTransaction.Amount < 0)
            {
                return Unauthorized();
            }
            else
            {
                account.Balance -= accountTransaction.Amount;
                _context.SaveChanges();
            }

            return account;
        }

        [HttpGet("Get/{number}", Name = "GetByNumber")]
        // GET: Accounts/number
        public async Task<ActionResult<Account>> Get(string number)
        {
            _logger.Log(LogLevel.Information, "Web API Accounts/Get called");

            if (number == null)
                return NotFound();

            var account =
                await _context.Account
                .FirstOrDefaultAsync(m => m.Number == number);

            if (account == null)
                return NotFound();

            return account;
        }
    }
}
