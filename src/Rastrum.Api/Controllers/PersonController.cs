using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Rastrum.Api.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rastrum.Api
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<Person>> GetAsync()
        {
            return await _personService.ListAllPeopleAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpPatch("{id}")]
		public async Task<IActionResult> Patch(int id, [FromBody]JsonPatchDocument<Person> patch)
		{
            var person = await _personService.GetPersonAsync(id);

			patch.ApplyTo(person, ModelState);

			if (!ModelState.IsValid)
			{
				return new BadRequestObjectResult(ModelState);
			}

			return Ok(person);
		}

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
