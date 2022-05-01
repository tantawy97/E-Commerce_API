using E_Commerce.Models;

namespace E_Commerce.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly ECommerceContext db;

        public ProductRepository(ECommerceContext db)
        {
            this.db = db;
        }
        public  List<Product> GetAll()
        {
            List<Product> products = db.Products.ToList();
            return products;
        }
    }
}
