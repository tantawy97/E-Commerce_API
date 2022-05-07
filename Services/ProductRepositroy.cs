using E_Commerce.Models;
using E_Commerce.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly ECommerceContext db;

        public ProductRepository(ECommerceContext db)
        {
            this.db = db;
        }



        public async Task<List<Product>> GetAll()
        {

            List<Product> products = await db.Products.ToListAsync();
         
            foreach(var item in products)
            {

            }
                return products;
            

        }

     public async   Task<ProductViewModel> Create(ProductViewModel productVM)
        {
            Product product = new Product()
            {
                Name = productVM.Name,
                Price = productVM.Price,
                Quantity = productVM.Quantity,
                Categoryid = productVM.Categoryid,
            };
           
                if (productVM.Image.Length > 0)
                {
                    using (var stream = new MemoryStream())
                    {
                        await productVM.Image.CopyToAsync(stream);
                        product.Image = stream.ToArray();
                    }
                }
            
            await db.Products.AddAsync(product);
            db.SaveChanges();
            return productVM;

        }
    }
}
