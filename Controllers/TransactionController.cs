namespace fake_bank_app.Controllers
{
    using fake_bank_app.models;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly UserTransactionService _userTransactionService;
        public TransactionController(UserTransactionService userTransactionService)
        {
            _userTransactionService = userTransactionService;
        }
        // GET api/values
        [HttpGet]
        [Route("GetTransaction")]
        public ActionResult<Transaction> GetTransaction()
        {
            return _userTransactionService.GetTransaction();
        }

        [HttpGet]
        [Route("GetUser")]
        public ActionResult<User> GetUser()
        {
            return _userTransactionService.GetUser();
        }
    }
}

// [HttpGet("{id}")]
        // [HttpDelete("{id}")]
        // [HttpPut("{id}")]
        // [HttpPost]
        // public void Post([FromBody] string value)
        // {
        // }
        // [HttpGet("{id}")]
        // public ActionResult<string> Get(int id)
        // {
        //     return "value";
        // }
