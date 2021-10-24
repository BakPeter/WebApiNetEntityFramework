using System.Collections.Generic;
using System.Threading.Tasks;
using my_dotnet5_rpg.Dtos.Fight;
using my_dotnet5_rpg.Models;

namespace my_dotnet5_rpg.Services.FigthService
{
    public interface IFightService
    {
        
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);
        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
        Task<ServiceResponse<List<HighscoreDto>>> GetHighscore();
    }
}