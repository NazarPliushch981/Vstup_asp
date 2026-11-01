using Microsoft.AspNetCore.Mvc;
using Vstup_asp.ViewModels;

namespace Vstup_asp.Controllers
{
    public class DiscountController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new DiscountViewModel());
        }

        [HttpPost]
        public IActionResult Index(DiscountViewModel model)
        {
            decimal discountSum = model.Price * model.DiscountPercent / 100;
            model.FinalPrice = model.Price - discountSum;
            model.Message = $" економія:{discountSum}";

            return View(model);
        }
    }
}