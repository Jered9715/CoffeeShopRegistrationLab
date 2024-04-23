namespace CoffeeShopRegistration.DAL
{
    public class ProductsRepository
    {
        private readonly CoffeeProductsDbContext _context;

        public ProductsRepository(CoffeeProductsDbContext context)
        {
            _context = context;
        }

        //Get all products

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        //Get products by Category

        public List<Product> GetProductsByCategory(string category)
        { 
            return _context.Products.Where(p => p.Category == category).ToList();
        }

        //Delete an a product

        public void DeleteProduct(int id)
        {
            Product product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

      



    }
}
