using Charme.Models;
namespace Charme.Services
{
    public class ContactService
    {
        private Contact _contact; //guarda um contato na memória

        public Contact GetContact() //esse é o get e vai me retornar o contato salvo
        {
            return _contact;
        }

        public void SetContact(Contact contact) // esse é o post, está em standby
        {
            _contact = contact;
        }

        public ContactService()
        {
            _contact = new Contact
            {
                Phone = "9157225554",
                Address = "Rua Marinheiro - Marinhos - Marreco",
                Instagram = "instagram/user15321"
            };
        }
    }
}
