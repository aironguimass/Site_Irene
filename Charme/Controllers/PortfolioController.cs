using Microsoft.AspNetCore.Mvc;
using Charme.Models;
using Charme.Services;
using System.Collections.Generic;

namespace Charme.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PortfolioController : ControllerBase

    {
        private readonly PortfolioService _portfolioService;

    public PortfolioController(PortfolioService portfolioService)
    {
        _portfolioService = portfolioService;
    }

    [HttpGet]
    public ActionResult<List<Portfolio>> GetPortfolio()
    {
        return _portfolioService.GetPortfolio();
    }




    [HttpPost]
    public IActionResult AddPortfolioItem([FromBody] Portfolio item)
    {
        if (item == null || string.IsNullOrEmpty(item.Title) || string.IsNullOrEmpty(item.Description))
        {
            return BadRequest("Dados do portfólio inválidos");
        }
        _portfolioService.AddPortfolioItem(item);
        return Ok(item);

    }
}
    
}
