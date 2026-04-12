using Charme.Models;

namespace Charme.Services
{
    public class AboutService
    {
        private About? _about = new()
        {
            Title = "Sobre o Charme",
            Description = "O salão Charme nasceu em 2022 e oferece serviços de qualidade."
        };

        public About? Get() => _about;

        public About Create(About about)
        {
            _about = about;
            return _about;
        }

        public About? Update(About about)
        {
            if (_about == null) return null;
            _about = about;
            return _about;
        }

        public bool Delete()
        {
            if (_about == null) return false;
            _about = null;
            return true;
        }
    }
}