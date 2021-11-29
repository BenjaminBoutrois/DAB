namespace DAB.Webservice.Models
{
    public class AccountTransaction
    {
        #region Constructors

        public AccountTransaction (string accountNumber, double amount)
        {
            AccountNumber = accountNumber;
            Amount = amount;
        }

        #endregion Constructors

        #region Properties

        public string AccountNumber { get; set; }

        public double Amount { get; set; }

        #endregion Properties
    }
}
