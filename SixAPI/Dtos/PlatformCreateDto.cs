using System.ComponentModel.DataAnnotations;

namespace SixAPI.Dtos
{
    public class PlatformCreateDto
    {
        [Required]
        public string? PlatformName { get; set; }
    }
}