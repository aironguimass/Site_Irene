using Microsoft.AspNetCore.Mvc;
using Charme.Models;

namespace Charme.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetContact()
        {
            var contact = new Contact
            {
                Phone = "(11) 99999-9999",
                Address = "Rua das Flores, 123, Cidade",
                Instagram = "@charme_salao"
            };
            return Ok(contact);
        }
    }
}