using System.ComponentModel.DataAnnotations;
namespace SistemPerMenaxhiminESpitalit.Data
{
    internal sealed class State
    {
        [Required]
        [MaxLength(length: 40)]
        public string Name { get; set; } = string.Empty;
    }
}
