using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using my_dotnet5_rpg.Dtos.Character;
using my_dotnet5_rpg.Dtos.Weapon;
using my_dotnet5_rpg.Models;
using my_dotnet5_rpg.Services.WeaponService;

namespace my_dotnet5_rpg.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WaeponController : ControllerBase
    {
        private readonly IWeaponService _weaponService;
        public WaeponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
        {
            return Ok(await _weaponService.AddWeapon(newWeapon));
        }
    }
}