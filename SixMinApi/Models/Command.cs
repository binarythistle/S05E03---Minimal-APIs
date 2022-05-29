using System.ComponentModel.DataAnnotations;

namespace SixMinApi.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? HowTo { get; set; }

        [Required]
        [MaxLength(6)]
        public string? Platform { get; set; }

        [Required]
        public string? CommandLine { get; set; }
    }
}