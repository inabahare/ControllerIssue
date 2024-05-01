using Microsoft.AspNetCore.Mvc;

namespace ControllersInOtherProject.Controllers;
[ApiController]
public class ProjectController : ControllerBase
{
    [HttpGet("project")]
    public ActionResult<string> Get()
    {
        return Ok("Hello from main project");
    }
}
