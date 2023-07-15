using FirstAssignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public PersonController() { }


        [HttpPost]
        public Person Post([FromBody] Person person)
        {
            return person;
        }
    }
}
