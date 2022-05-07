using E_Commerce.Models;

namespace E_Commerce.Services
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAll();
    }
}
