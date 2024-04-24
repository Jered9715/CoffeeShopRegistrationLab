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


        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _repo.AddProduct(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            List<Product> products = _repo.GetProducts();
            Product selected = products.FirstOrDefault(x => x.Id == id);
            return View(selected);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _repo.DeleteProduct(id);
            return RedirectToAction("Index");

        }

    }
}
