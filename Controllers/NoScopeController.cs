using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
[Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
[ApiController]
public class NoScopeController : ControllerBase
{
    
    [HttpGet]
    public IActionResult GetData() => Ok("Protected API data");
}
