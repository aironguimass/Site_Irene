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


        [HttpGet] // vai retornar o contato salvo no código
        public ActionResult<Contact> GetContact()
        {
            return _contactService.GetContact();
        }

        [HttpPost] //recebe os dados do painel adm
        public IActionResult AddContact([FromBody] Contact contact)
        {
            if (contact == null || string.IsNullOrEmpty(contact.Phone)
                || string.IsNullOrEmpty(contact.Address)
                || string.IsNullOrEmpty(contact.Instagram))

            {
                return BadRequest("Dados do contato inválidos");
            }

                _contactService.SetContact(contact);
                return Ok(contact);
        }
    }
}