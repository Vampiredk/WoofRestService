using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoofRestService.Manager;
using WoofRestService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WoofRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WoofController : ControllerBase
    {
        // GET: api/<WoofController>
        private WoofManager _manager = new WoofManager();
        [HttpGet]
        public IEnumerable<Woof> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<WoofController>/5
        [HttpGet("{id}")]
        public Woof Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<WoofController>
        [HttpPost]
        public void Post([FromBody] Woof value)
        {
            _manager.Add(value);
        }

        // PUT api/<WoofController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Woof value)
        {
            _manager.Update(id, value);
        }

        // DELETE api/<WoofController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
