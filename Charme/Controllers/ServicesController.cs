using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Charme.Models;
using Charme.Services;// Importa a classe Service

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
            if (service == null || string.IsNullOrEmpty(service.Name) || string.IsNullOrEmpty(service.Description))
                return BadRequest("Dados do serviço inválidos");
            

            var Services = _serviceService.GetServices();
            return Ok(service);
        }
    }
}