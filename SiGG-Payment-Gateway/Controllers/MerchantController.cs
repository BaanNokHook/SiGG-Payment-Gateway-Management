using Microsoft.AspNetCore.Mvc;

namespace SiGG_Payment_Gateway.Controllers
{

    [Route("api/controller")]
    [ApiController]
    public class MerchantController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<MerchantController> _logger;
        private object txn_date;

        public MerchantController(ILogger<MerchantController> logger)
        {
            _logger = logger;
        }


        [HttpGet("v1/Merchant")]
        public IEnumerable<Transactions> Post()
        {
            return Enumerable.Range(1, 5).Select(index => new Transactions
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                txn_date = Summaries[Random.Shared.Next(Summaries.Length)],
                mid = Summaries[Random.Shared.Next(Summaries.Length)],
            })
            .ToArray();
        }


        [HttpGet("v1/Merchant/Agents")]
        public IEnumerable<Transactions> Get1()
        {
            return Enumerable.Range(1, 5).Select(index => new Transactions
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                txn_date = Summaries[Random.Shared.Next(Summaries.Length)],
                mid = Summaries[Random.Shared.Next(Summaries.Length)],
            })
            .ToArray();
        }


        [HttpGet("v1/Merchant/Address")]
        public IEnumerable<Transactions> Get2()
        {
            return Enumerable.Range(1, 5).Select(index => new Transactions
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                txn_date = Summaries[Random.Shared.Next(Summaries.Length)],
                mid = Summaries[Random.Shared.Next(Summaries.Length)],
            })
            .ToArray();
        }


        [HttpGet("v1/Merchant/Mdrs")]
        public IEnumerable<Transactions> Get3()
        {
            return Enumerable.Range(1, 5).Select(index => new Transactions
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                txn_date = Summaries[Random.Shared.Next(Summaries.Length)],
                mid = Summaries[Random.Shared.Next(Summaries.Length)],
            })
            .ToArray();
        }


        [HttpGet("v1/Merchant/TransactionTypes")]
        public IEnumerable<Transactions> Get4()
        {
            return Enumerable.Range(1, 5).Select(index => new Transactions
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                txn_date = Summaries[Random.Shared.Next(Summaries.Length)],
                mid = Summaries[Random.Shared.Next(Summaries.Length)],
            })
            .ToArray();
        }
    }
}
