using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SiGG_Payment_Gateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<TransactionsController> _logger;
        private object txn_date;

        public TransactionsController(ILogger<TransactionsController> logger)
        {
            _logger = logger;
        }


        [HttpGet("v1/{id}")]
        public IEnumerable<Transactions> Get()
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

        [HttpGet("v1")]
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

        [HttpGet("v1/Settlements")]
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

        [HttpPost("v1/Transactions/Void/{id}")]
        public IEnumerable<Transactions> Post1()
        {
            return Enumerable.Range(1, 5).Select(index => new Transactions
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost("v1/Transactions/Refund/{id}/{amount}")]
        public IEnumerable<Transactions> Post2()
        {
            return Enumerable.Range(1, 5).Select(index => new Transactions
            {
                Data = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();  
        }

        [HttpPost("v1/Transactions/Capture/{id}/{amount}")]
        public IEnumerable<Transactions> Post3()
        {
            return Enumerable.Range(1, 5).Select(index => new Transactions
            {
                Data = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("v1/Transactions/FPX/Banks/{type}")]
        public IEnumerable<Transactions> Get3()
        {
            return Enumerable.Range(1, 5).Select(index => new Transactions
            {
                Data = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost("v1/Transactions/Splits/{id}")]
        public IEnumerable<Transactions> Post4()
        {
            return Enumerable.Range(1, 5).Select(index => new Transactions
            {
                Data = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }

}

