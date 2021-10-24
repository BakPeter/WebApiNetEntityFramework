using System.Text.Json.Serialization;

namespace my_dotnet5_rpg.Models
{
  [JsonConverter(typeof(JsonStringEnumConverter))]
  public enum RpgClass
  {
    Knight,
    Mage,
    Cleric  
  }
}