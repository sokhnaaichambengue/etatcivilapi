using EtatCivilAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EtatCivilAPI.Controllers
{
    [Route("api/person")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private List<Person> _personRepository = new List<Person>();
        private List<Death> _deathRepository = new List<Death>();

        public PersonController() 
        {
        
        }

        [HttpPost("birth")]
        public void SaveBirth([FromBody] Person person)
        {
            person.Id = new Random().Next();

            _personRepository.Add(person);
        }

        [HttpPost("death")]
        public void SaveDeath([FromBody] Death death)
        {
            _deathRepository.Add(death);
        }
    }
}
