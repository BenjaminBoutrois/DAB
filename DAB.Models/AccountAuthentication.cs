namespace DAB.Webservice.Models
{
    public class AccountAuthentication
    {
        #region Constructors

        public AccountAuthentication (string number, string pin)
        {
            Number = number;
            Pin = pin;
        }

        #endregion Constructors

        #region Properties

        public string Number { get; set; }

        public string Pin { get; set; }

        #endregion Properties
    }
}
