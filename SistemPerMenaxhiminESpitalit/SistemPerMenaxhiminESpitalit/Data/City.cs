using System.ComponentModel.DataAnnotations;
namespace SistemPerMenaxhiminESpitalit.Data
{
    internal sealed class City
    {
        public string? CityId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
