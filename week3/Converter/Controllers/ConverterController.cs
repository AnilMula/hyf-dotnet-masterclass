using Microsoft.AspNetCore.Mvc;
using Converter.Models;

namespace Converter.Controllers;

[ApiController]
[Route("converter")]
public class ConverterController : ControllerBase
{

    [HttpGet("GallonsToLitres")]
    public double GallonsToLitres(int gallons)
    {
        return 3.785 * gallons;
    }

    [HttpGet("ConvertMiles")]
    public Distance ConvertMiles(int miles)
    {
        return new Distance { Miles = miles, Kilometers = miles * 1.609 };
    }

    [HttpPost("convert")]
    public List<ConversionResponse> ConvertValues([FromBody] ConversionRequest Request)
    {
        return new ConversionResponse().Convert(Request);
    }
}