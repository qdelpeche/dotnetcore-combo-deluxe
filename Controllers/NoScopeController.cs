using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreComboDeluxe.Models;

[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
[Microsoft.AspNetCore.Mvc.Route("api/noscope")]
[ApiController]
public class NoScopeController : ControllerBase
{
    
    [HttpGet]
    [Produces("application/json")]
    public ActionResult<ResponseModel> Get()
    {
        var result = new ResponseModel
        {
            Message = "This is a protected endpoint but requires no scope",
            Date = DateTime.UtcNow
        };
        
        return Ok(result);
    }
}
