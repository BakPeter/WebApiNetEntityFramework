using System.Collections.Generic;
using my_dotnet5_rpg.Dtos.Skill;
using my_dotnet5_rpg.Dtos.Weapon;
using my_dotnet5_rpg.Models;

namespace my_dotnet5_rpg.Dtos.Character
{
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
        public GetWeaponDto Weapon { get; set; }
        public List<GetSkillDto> Skills { get; set; }
        public int Figths { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }
    }
}