using Microsoft.AspNetCore.Mvc;
using Charme.Models;
using Charme.Services;

namespace Charme.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ContactService _contactService;

        public ContactController(ContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public ActionResult<Contact> Get()
        {
            var contact = _contactService.Get();
            if (contact == null) return NotFound();
            return Ok(contact);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Contact contact)
        {
            if (contact == null ||
                string.IsNullOrWhiteSpace(contact.Phone) ||
                string.IsNullOrWhiteSpace(contact.Address) ||
                string.IsNullOrWhiteSpace(contact.Instagram))
                return BadRequest("Dados do contato inválidos");

            return Ok(_contactService.Create(contact));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Contact contact)
        {
            if (contact == null ||
                string.IsNullOrWhiteSpace(contact.Phone) ||
                string.IsNullOrWhiteSpace(contact.Address) ||
                string.IsNullOrWhiteSpace(contact.Instagram))
                return BadRequest("Dados do contato inválidos");

            var updated = _contactService.Update(contact);
            if (updated == null) return NotFound();

            return Ok(updated);
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            var ok = _contactService.Delete();
            if (!ok) return NotFound();

            return NoContent();
        }
    }
}