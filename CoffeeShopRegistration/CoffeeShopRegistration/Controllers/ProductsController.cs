using CoffeeShopRegistration.DAL;
using CoffeeShopRegistration.Models;
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
        
        public IActionResult Index()
        {
            List<Product> products = _repo.GetProducts();
            return View(products);
        }
    }
}
