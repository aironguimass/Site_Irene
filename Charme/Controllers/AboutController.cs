
using Charme.Models;
using Charme.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Charme.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]

    public class AboutController : ControllerBase
    {
        private readonly AboutService _aboutService;
        public AboutController(AboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public ActionResult<About> GetAbout()
        {
            var about = _aboutService.GetAbout();
            return about;
        }
        [HttpPost]
        public IActionResult GetAbout([FromBody] About about)
        {
           
          if (about == null || string.IsNullOrEmpty(about.Title) || string.IsNullOrEmpty(about.Description))
            {
                return BadRequest("Dados do About inválidos.");
            }

            return Ok(about);
        }
    }    
  
}