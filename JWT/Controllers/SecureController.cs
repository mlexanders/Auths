using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class SecureController : ControllerBase
{
    [HttpGet]
    public IActionResult GetSecureData()
    {
        var username = HttpContext.User.Identity?.Name;
        var token = HttpContext.Request.Headers.Authorization.ToString();
        return Ok($"This is secure data {username}");
    }
}