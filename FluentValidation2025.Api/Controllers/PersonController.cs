using FluentValidation2025.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidation2025.Api.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
            return Ok();
        }
    }
}
