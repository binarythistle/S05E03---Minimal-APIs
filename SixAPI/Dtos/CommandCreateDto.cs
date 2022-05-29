using System.ComponentModel.DataAnnotations;

namespace SixAPI.Dtos
{
    public class CommandCreateDto
    {
        [Required]
        public string? HowTo { get; set; }

        [Required]
        [MaxLength(7)]
        public string? Platform { get; set; }

        [Required]
        public string? CommandLine { get; set; }
    }
    
}