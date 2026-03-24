using Charme.Models;

namespace Charme.Services
{
    public class AboutService
    {
        private About _about;

        public About GetAbout() 
        {
            return _about; //returna o que ta salvo na memória
        }
        public void SetAbout(About about)
        {
            _about = about; //define o objeto em uma memoria
        }
        public AboutService()
        {
            // Valor padrão inicial
            _about = new About
            {
                Title = "Sobre o Charme",
                Description = "O salão Charme nasceu em 2022 e oferece serviços de qualidade."
            };
        }

    }
}
