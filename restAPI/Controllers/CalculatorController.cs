using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace restAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    [HttpGet("sum/{firstNumber}/{secondNumber}")]
    public IActionResult Get(string firstNumber, string secondNumber)
    {
        if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
        {
            var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
            return Ok(sum.ToString(CultureInfo.InvariantCulture));
        }
        return BadRequest("Invalid input");
    }

    private bool IsNumeric(string firstNumber)
    {
        throw new NotImplementedException();
    }

    private decimal ConvertToDecimal(string secondNumber)
    {
        throw new NotImplementedException();
    }
}