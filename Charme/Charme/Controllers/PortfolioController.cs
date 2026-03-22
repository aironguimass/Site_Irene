using Microsoft.AspNetCore.Mvc;
using Charme.Models;
using System.Collections.Generic;

namespace Charme.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PortfolioController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetPortfolio()
        {
            var   portfolio = new List<Portfolio>
            {
                new Portfolio { Id = 1, Title = "Manicure", ImageUrl = "https://linkdafoto.com/unha1.jpg", Description = "Unha em gel com decoração floral" },
                new Portfolio { Id = 2, Title = "Cabelo", ImageUrl = "https://linkdafoto.com/cabelo1.jpg", Description = "Corte feminino moderno" },
                new Portfolio { Id = 3, Title = "Pedicure", ImageUrl = "https://linkdafoto.com/unha2.jpg", Description = "Unha porcelana clássica" },
            };
            return Ok(portfolio);
        }
        
    }
}
