using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using SixAPI.Binders;

namespace SixAPI.Models
{

    [ModelBinder(BinderType = typeof(PlatformModelBinder))]
    public class Platform
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? PlatformName { get; set; }
    }
}