namespace AES.UniversalBank.Messaging.Broker
{
    public class AccountInfoRequest
    {
        public string CustomerId { get; set; }
        public RequestType Type { get; set; }

        public enum RequestType
        {
            Account,
            Customer,
            Loan,
            Transaction
        }
    }
}
