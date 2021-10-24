using System.Threading.Tasks;
using my_dotnet5_rpg.Dtos.Character;
using my_dotnet5_rpg.Dtos.Weapon;
using my_dotnet5_rpg.Models;

namespace my_dotnet5_rpg.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
         
    }
}