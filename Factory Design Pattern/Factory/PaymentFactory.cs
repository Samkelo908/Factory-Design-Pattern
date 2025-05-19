using Factory_Design_Pattern.Models;

namespace Factory_Design_Pattern.Factory
{
    public static class PaymentFactory
    {
        public static IPaymentMethod GetPaymentMethod(string type)
        {
            switch (type.ToLower())
            {
                case "paypal":
                    return new PayPalPayment();
                case "creditcard":
                    return new CreditCardPayment();
                case "bank":
                    return new BankTransferPayment();
                default:
                    throw new ArgumentException("Invalid payment type.");
            }
        }
    }
}
