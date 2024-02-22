using CarRental.DataAcces;
using CarRental.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {

        public IRepository repository;
        public VehicleController(IRepository Repository)
        {
            repository = Repository;
        }

        // GET: api/<VehicleController>
        [HttpGet]
        public IEnumerable<string> Get()  =>
            repository.Vehicle().Select(s => s.Registration).Distinct().ToArray();

        // GET api/<VehicleController>/5
        [HttpGet("{id}")]
        public Vehicle Get(string id) => 
            repository.Vehicle().FirstOrDefault(s => s.Registration == id) ?? new Vehicle();

        // POST api/<VehicleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VehicleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VehicleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
