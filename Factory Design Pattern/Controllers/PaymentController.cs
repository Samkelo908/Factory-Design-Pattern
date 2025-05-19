using Factory_Design_Pattern.Factory;
using Factory_Design_Pattern.Models;
using Microsoft.AspNetCore.Mvc;

namespace Factory_Design_Pattern.Controllers
{
    public class PaymentController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Process(string paymentType, decimal amount)
        {
            IPaymentMethod method = PaymentFactory.GetPaymentMethod(paymentType);
            string result = method.ProcessPayment(amount);
            ViewBag.Result = result;
            return View("Result");
        }
    }
}
