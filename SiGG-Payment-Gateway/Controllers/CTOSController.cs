using Microsoft.AspNetCore.Mvc;

namespace SiGG_Payment_Gateway.Controllers
{

    [Route("api/controller")]
    [ApiController]
    public class CtosController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<CtosController> _logger;
        private object txn_date;

        public CtosController(ILogger<CtosController> logger)
        {
            _logger = logger;
        }


        [HttpPost("v1/Integration/Ctos")]
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


        [HttpPut("v1/Integration/Ctos")]
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


        [HttpGet("v1/Integration/Ctos")]
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

    }
}