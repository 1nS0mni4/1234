using Microsoft.AspNetCore.Mvc;
using WebServer.Models;

namespace WebServer.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class AccountRegisterController : ControllerBase {
        private Dictionary<string, string> _accounts = new();

        public AccountRegisterController()
        {
            
        }

        [HttpGet]
        public bool Get() {
            return true;
        }

        [HttpPost]
        public Account Post(Account account) {
            if(_accounts.ContainsKey(account.ID) == true)
                return null;

            _accounts[account.ID] = account.PW;
            return account;
        }
    }
}