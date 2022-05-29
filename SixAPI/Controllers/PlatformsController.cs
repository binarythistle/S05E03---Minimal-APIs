using Microsoft.AspNetCore.Mvc;
using SixAPI.Models;

namespace SixAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]   
    public class PlatformsController : ControllerBase
    {
        

        [HttpGet("binder/{id}")]
        public IActionResult GetPlatformById(
            [ModelBinder(Name = "id")] Platform platform)
        {
            if (platform == null)
            {
                return NotFound();
            }

            return Ok(platform);
        }
    }
}