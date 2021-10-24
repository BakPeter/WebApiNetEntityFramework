using AutoMapper;
using my_dotnet5_rpg.Dtos.Character;
using my_dotnet5_rpg.Dtos.Skill;
using my_dotnet5_rpg.Dtos.Weapon;
using my_dotnet5_rpg.Models;

namespace my_dotnet5_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
        }
    }
}