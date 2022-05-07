using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Services
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly ECommerceContext db;
        public CategoryRepository(ECommerceContext db)
        {
            this.db = db;
        }



        public async Task<List<Category>> GetAll()
        {
            List<Category> Categories = await db.Categories.ToListAsync();
            return Categories;
        }
    }
}
