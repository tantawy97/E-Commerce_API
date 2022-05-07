using System.Threading.Tasks;
using TestApiJWT.Models;

namespace TestApiJWT.Services
{
    public interface IUserRepository
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> SignIn(SignInModel model);

    }
}