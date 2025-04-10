using FluentValidation;
using FluentValidation2025.Api.Extensions;
using FluentValidation2025.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidation2025.Api.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IValidator<Person> _personValidator;

        public PersonController(IValidator<Person> personValidator)
        {
            _personValidator = personValidator;
        }

        [HttpPost]
        public async Task<IActionResult> AddPerson(Person person)
        {
            var personValidator = await _personValidator.ValidateAsync(person);

            if (!personValidator.IsValid)
            {
                personValidator.AddToModelState(ModelState);
                return UnprocessableEntity(ModelState);
            }
            return Ok();
        }
    }
}
