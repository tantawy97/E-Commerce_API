using E_Commerce.Models;
using E_Commerce.ViewModel;

namespace E_Commerce.Services
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAll();
        Task<ProductViewModel> Create(ProductViewModel productVM);
    }
}
