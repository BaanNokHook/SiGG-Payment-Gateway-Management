using Microsoft.AspNetCore.Mvc;

namespace SiGG_Payment_Gateway.Controllers
{

    [Route("api/controller")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<DeliveryController> _logger;
        private object txn_date;

        public DeliveryController(ILogger<DeliveryController> logger)
        {
            _logger = logger;
        }

        [HttpGet("v1/Delivery/Locations/{postcode}")]
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


        [HttpGet("v1/Delivery/Dates/{postcode}")]
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


        [HttpGet("v1/Delivery/Time/{date}")]
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


        [HttpPost("v1/Delivery/Rates")]
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


        [HttpPost("v1/Delivery/Rates/SameDay")]
        public IEnumerable<Transactions> Post1()
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


        [HttpPost("v1/Delivery/Orders")]
        public IEnumerable<Transactions> Post2()
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


        [HttpGet("v1/Delivery/Orders")]
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


        [HttpPut("v1/Delivery/Orders")]
        public IEnumerable<Transactions> Put()
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


        [HttpDelete("v1/Delivery/Orders")]
        public IEnumerable<Transactions> Delete()
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