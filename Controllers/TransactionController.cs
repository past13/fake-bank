namespace fake_bank_app.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly TransactionService _transactionService;
        public TransactionController(TransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        // GET api/values
        [HttpGet]
        [Route("GetTransaction")]
        public ActionResult<Transaction> GetTransaction()
        {
            var test = _transactionService.GetTransaction();

            return test;
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
