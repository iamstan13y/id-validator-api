using IDValidator.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace IDValidator.API.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class ValidationController : ControllerBase
{
    private readonly IValidatorService _validatorService;

    public ValidationController(IValidatorService validatorService) => _validatorService = validatorService;

    [HttpGet("authenticity/{idNumber}")]
    public IActionResult Get(string idNumber)
    {
        var result = _validatorService.CheckAuthenticityAsync(idNumber);
        
        if(!result.Success) return BadRequest(result);

        return Ok(result);
    }
}