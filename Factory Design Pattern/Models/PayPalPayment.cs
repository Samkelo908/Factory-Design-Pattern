namespace Factory_Design_Pattern.Models
{
    public class PayPalPayment : IPaymentMethod
    {
        public string ProcessPayment(decimal amount)
        {
            return $"Processed {amount:C} through PayPal.";
        }
    }

    // Models/CreditCardPayment.cs
    public class CreditCardPayment : IPaymentMethod
    {
        public string ProcessPayment(decimal amount)
        {
            return $"Processed {amount:C} through Credit Card.";
        }
    }
}
