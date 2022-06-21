using Microsoft.AspNetCore.Mvc;
using PersonWeb.Model;
using PersonWeb.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IServicePerson _servicePerson;
        public PersonController(IServicePerson _servicePerson) {

            this._servicePerson = _servicePerson;
        }
        public PersonController()
        { 
        }
        public ViewResult CreatedPerson(Person person) 
        {
            if (!_servicePerson.EsValido(person)) {
                _servicePerson.Errores.Add("Hay Errores");
                
                return ViewResult();
            }
            return ViewResult();
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
