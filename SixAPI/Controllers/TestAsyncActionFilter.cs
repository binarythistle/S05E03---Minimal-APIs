using System.Text;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SixAPI.Controllers
{
    public class TestAsyncActionFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var qs = context.HttpContext.Request.QueryString;
            
            //var requestBody = context.HttpContext.Request.Body.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--> Action Filter doing something BEFORE the Action...");
            Console.WriteLine($"--> Query string: {qs}");
            
            var result = await next();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--> Action Filter doing something AFTER the Action...");
            Console.ResetColor();
        }
    }
}