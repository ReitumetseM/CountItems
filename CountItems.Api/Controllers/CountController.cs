using Microsoft.AspNetCore.Mvc;
using CountItems.Api.Services;
using System.Collections.Generic;

namespace CountItems.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountController : ControllerBase
    {
        private readonly ICountService _countService;

        public CountController(ICountService countService)
        {
            _countService = countService;
        }

        [HttpPost("count")]
        public ActionResult<Dictionary<string, int>> CountItems([FromBody] List<string> items)
        {
            if (items == null || items.Count == 0)
                return BadRequest("Items list cannot be empty");

            var result = _countService.CountItems(items);
            return Ok(result);
        }

        [HttpPost("count-numbers")]
        public ActionResult<Dictionary<int, int>> CountNumbers([FromBody] List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
                return BadRequest("Numbers list cannot be empty");

            var result = _countService.CountItems(numbers);
            return Ok(result);
        }
    }
}