using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace tasksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        // GET: api/MiControlador
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Valor1", "Valor2" };
        }

        // GET: api/MiControlador/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<string> Get(int id)
        {
            return "Valor";
        }

        // POST: api/MiControlador
        [HttpPost]
        public ActionResult Post([FromBody] string value)
        {
            // Aquí puedes manejar la lógica para crear un recurso
            // y devolver una respuesta apropiada.
            return CreatedAtAction("Get", new { id = 1 }, value);
        }

        // PUT: api/MiControlador/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string value)
        {
            // Aquí puedes manejar la lógica para actualizar un recurso
            // y devolver una respuesta apropiada.
            return NoContent();
        }

        // DELETE: api/MiControlador/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            // Aquí puedes manejar la lógica para eliminar un recurso
            // y devolver una respuesta apropiada.
            return NoContent();
        }
    }
}