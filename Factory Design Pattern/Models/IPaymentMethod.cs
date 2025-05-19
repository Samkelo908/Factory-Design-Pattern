namespace Factory_Design_Pattern.Models
{
    public interface IPaymentMethod
    {
        string ProcessPayment(decimal amount);
    }
}
