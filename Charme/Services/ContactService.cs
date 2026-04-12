using Charme.Models;

namespace Charme.Services
{
    public class ContactService
    {
        private Contact? _contact = new()
        {
            Phone = "(00) 00000-0000",
            Address = "Seu endereço aqui",
            Instagram = "@seuinstagram"
        };

        public Contact? Get() => _contact;

        public Contact Create(Contact contact)
        {
            _contact = contact;
            return _contact;
        }

        public Contact? Update(Contact contact)
        {
            if (_contact == null) return null;
            _contact = contact;
            return _contact;
        }

        public bool Delete()
        {
            if (_contact == null) return false;
            _contact = null;
            return true;
        }
    }
}