using Microsoft.AspNetCore.Mvc;

namespace ProjectWebApplication.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            return View();
        }
    }
}

