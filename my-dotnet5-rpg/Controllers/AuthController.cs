using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using my_dotnet5_rpg.Data;
using my_dotnet5_rpg.Dtos.User;

namespace my_dotnet5_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;
        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<int>> Register(UserRegisterDto request)
        {
            var response = await _authRepo.Register(
                new Models.User() { UserName = request.UserName},
                request.Password
            );

            if(!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

         [HttpPost("Login")]
        public async Task<ActionResult<string>> Login(UserLoginDto request)
        {
            var response = await _authRepo.Login(
                request.UserName,
                request.Password
            );

            if(!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}