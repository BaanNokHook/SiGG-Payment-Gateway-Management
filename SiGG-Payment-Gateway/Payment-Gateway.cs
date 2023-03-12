namespace SiGG_Payment_Gateway
{
    public class Auth
    {
        public DateTime expiration { get; set; }

        public string token { get; set; }
    }

    public class PaymentGateway
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }

    public class Transactions
    {
        internal object txn_date;
        internal string mid;

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}


