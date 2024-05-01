using ClassLibraryWithController;
using Microsoft.AspNetCore.Mvc;

namespace ProjectWithOtherController;


[ApiController]
public class TestController(TestService _testService) : ControllerBase
{
    [HttpGet("other-project")]
    public ActionResult<string> Test()
    {
        _testService.Hello();
        return Ok("Hello from class library");
    }
}
