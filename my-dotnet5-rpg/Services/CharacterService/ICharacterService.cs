using System.Collections.Generic;
using System.Threading.Tasks;
using my_dotnet5_rpg.Dtos.Character;
using my_dotnet5_rpg.Models;

namespace my_dotnet5_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
         Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
         Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
         Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdataCharacterDto updataCharacter);
         Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
         Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);

    }
}