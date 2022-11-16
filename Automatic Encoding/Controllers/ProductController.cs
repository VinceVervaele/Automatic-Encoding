using Automatic_Encoding.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Automatic_Encoding.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ProductVM product)
        {
            // return View(product)
            return View("output", product);

        }
    }
}
