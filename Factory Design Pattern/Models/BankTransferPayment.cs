namespace Factory_Design_Pattern.Models
{
    public class BankTransferPayment : IPaymentMethod
    {
        public string ProcessPayment(decimal amount)
        {
            return $"Processed {amount:C} through Bank Transfer.";
        }
    }
}
