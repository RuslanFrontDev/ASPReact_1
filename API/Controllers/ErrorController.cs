
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class ErrorController : ControllerBase
{
    [HttpGet("not-fount")]

    public IActionResult NotFoundError()
    {
        return NotFound();
    }
    [HttpGet("bad-request")]
    public IActionResult BadRequestError()
    {
        return BadRequest();
    }
    [HttpGet("unauthorized")]
    public IActionResult UnAuthorizedError()
    {
        return Unauthorized();
    }
    [HttpGet("validation-error")]
    public IActionResult ValidationError()
    {
        ModelState.AddModelError("validation-error1", "validationDetailsError");
        ModelState.AddModelError("validation-error2", "validationDetailsError");
        return ValidationError();
    }
    [HttpGet("server-error")]
    public IActionResult ServerError()
    {
        throw new Exception("server error");
    }
}
