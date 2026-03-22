using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Charme.Models; // Importa a classe Service

namespace Charme.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicesController : ControllerBase
    {
        
        [HttpPost]
        public IActionResult GetServices()
        {
            var services = new List<Service>
            {
                new Service { Id = 1, Name = "Corte de Cabelo", Description = "Corte masculino e feminino" },
                new Service { Id = 2, Name = "Manicure", Description = "Manicure profissional" }
            };
            return Ok(services);
        }
    }
}