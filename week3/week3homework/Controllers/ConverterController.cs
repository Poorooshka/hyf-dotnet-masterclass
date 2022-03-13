using Microsoft.AspNetCore.Mvc;

namespace week3homework.Controllers;

[ApiController]
[Route("converter")]
public class ConverterController : ControllerBase
{
    private readonly ILogger<ConverterController> _logger;

    public ConverterController(ILogger<ConverterController> logger)
    {
        _logger = logger;
    }
}
