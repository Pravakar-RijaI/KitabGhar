using Microsoft.AspNetCore.Mvc;
using Stripe;
using Stripe.Checkout;

namespace KitabGhar.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCheckout()
        {
            var domain = "https://localhost:7028";
            var options = new SessionCreateOptions
            {
                LineItems = new List<SessionLineItemOptions>
                {
                  new SessionLineItemOptions
                  {
                    // Provide the exact Price ID (for example, pr_1234) of the product you want to sell
                    Price = "price_1PKlDzLkYBOPrv0ggYnZQk3e",
                    Quantity = 1,
                  },
                },
                Mode = "payment",
                SuccessUrl = domain + "/Payment/PaymentSuccess",
                CancelUrl = domain + "/Home/Index",
            };
            var service = new SessionService();
            Session session = service.Create(options);

            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);
        }

        public IActionResult PaymentSuccess()
        {
            return View();
        }

        public IActionResult PaymentCancel()
        {
            return View();
        }
    }
}
