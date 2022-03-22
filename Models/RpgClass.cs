using System.Text.Json.Serialization;

namespace viggoWebApi.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        knight,
        mage,
        cleric
    }
}