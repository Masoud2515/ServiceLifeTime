using Interface;
using Microsoft.AspNetCore.Mvc;

namespace ServiceLifeTime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberController : ControllerBase
    {
        private readonly IGenerateNumber _generateNumber1;
        private readonly IGenerateNumber _generateNumber2;
        public NumberController(IGenerateNumber generateNumber1, IGenerateNumber generateNumber2)
        {
            _generateNumber1 = generateNumber1;
            _generateNumber2 = generateNumber2;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var number1 = await _generateNumber1.GetNumber();
            var number2 = await _generateNumber2.GetNumber();

            return Ok(new { Number_1 = number1, Number_2 = number2 });
        }
    }
}
