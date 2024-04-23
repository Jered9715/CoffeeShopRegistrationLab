using CoffeeShopRegistration.DAL;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopRegistration.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductsRepository _repo;

        public ProductsController(CoffeeProductsDbContext context) 
        {
            _repo = new ProductsRepository(context);
        }
        
        public IActionResult DisplayProducts()
        {
            return View();
        }
    }
}
