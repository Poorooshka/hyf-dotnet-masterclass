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

    [HttpGet("GallonsToLiters")]
    public double GallonsToLiters(int gallons)
    {
        return gallons * 3.785412;
        //formula on the homework page should be corrected
    }
    [HttpGet("ConvertMiles")]
    public Distance ConvertMiles(int miles)
    {
        return new Distance() { Miles = miles, Kilometers = miles * 1.609 };
    }
}
