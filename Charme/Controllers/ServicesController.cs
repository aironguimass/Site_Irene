using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Charme.Models;
using Charme.Services;
using System.Linq;

namespace Charme.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicesController : ControllerBase
    {

        private readonly ServiceService _serviceService;

        public ServicesController(ServiceService serviceService)
        {
            _serviceService = serviceService;
        }


        [HttpGet] //Vai buscar os dados que  escrevi no codigo
        public ActionResult<List<Service>> GetServices()
        {
            return _serviceService.GetServices();
        }


        [HttpPost] //vai buscar no banco de dados
        public ActionResult AddService([FromBody] Service service)
        {
            if (service == null || string.IsNullOrEmpty(service.Name) || string.IsNullOrWhiteSpace(service.Description))
                return BadRequest("Dados do serviço inválidos");


            return Ok(_serviceService.AddService(service));
        }
        [HttpPut("{id:int}")]
        public IActionResult UpdateService(int id, [FromBody] Service service)
        {
            if (service == null || string.IsNullOrWhiteSpace(service.Name) || string.IsNullOrWhiteSpace(service.Description))
                return BadRequest("Dados do serviço inválidos");

            var updated = _serviceService.UpdateService(id, service);
            if (updated == null) return NotFound();

            return Ok(updated);
        }


        [HttpDelete("{id:int}")]
        public IActionResult DeleteService(int id)
        {
            var ok = _serviceService.DeleteService(id);
            if (!ok) return NotFound();

            return NoContent();
        }
    }


}
