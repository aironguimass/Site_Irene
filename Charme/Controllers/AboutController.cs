using Microsoft.AspNetCore.Mvc;
using Charme.Models;
using Charme.Services;

namespace Charme.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AboutController : ControllerBase
    {
        private readonly AboutService _aboutService;

        public AboutController(AboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public ActionResult<About> Get()
        {
            var about = _aboutService.Get();
            if (about == null) return NotFound();
            return Ok(about);
        }

        [HttpPost]
        public IActionResult Create([FromBody] About about)
        {
            if (about == null ||
                string.IsNullOrWhiteSpace(about.Title) ||
                string.IsNullOrWhiteSpace(about.Description))
                return BadRequest("Dados do About inválidos");

            return Ok(_aboutService.Create(about));
        }

        [HttpPut]
        public IActionResult Update([FromBody] About about)
        {
            if (about == null ||
                string.IsNullOrWhiteSpace(about.Title) ||
                string.IsNullOrWhiteSpace(about.Description))
                return BadRequest("Dados do About inválidos");

            var updated = _aboutService.Update(about);
            if (updated == null) return NotFound();

            return Ok(updated);
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            var ok = _aboutService.Delete();
            if (!ok) return NotFound();

            return NoContent();
        }
    }
}