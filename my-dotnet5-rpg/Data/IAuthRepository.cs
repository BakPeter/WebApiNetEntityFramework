using System.Threading.Tasks;
using my_dotnet5_rpg.Models;

namespace my_dotnet5_rpg.Data
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>>  Register(User user, string password);
        Task<ServiceResponse<string>> Login(string userName, string password);
        Task<bool> UserExists(string userName);
        
    }
}