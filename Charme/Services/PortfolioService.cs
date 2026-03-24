using Charme.Models;

namespace Charme.Services
{
    public class PortfolioService
    {
        private List<Portfolio> _portfolio; //lista na memoria

        public List<Portfolio> GetPortfolio() //vai ler a lista
        {
            if (_portfolio == null)
            {
                _portfolio = new List<Portfolio>
                {
                    new Portfolio { Id = 1, Title = "Manicure", ImageUrl = "https://linkdafoto.com/unha1.jpg", Description = "Unha em gel com decoração floral" },
                    new Portfolio { Id = 2, Title = "Cabelo", ImageUrl = "https://linkdafoto.com/cabelo1.jpg", Description = "Corte feminino moderno" },
                    new Portfolio { Id = 3, Title = "Pedicure", ImageUrl = "https://linkdafoto.com/unha2.jpg", Description = "Unha porcelana clássica" }
                };
            }
            return _portfolio;
        }

        public void AddPortfolioItem(Portfolio item)
        {
            if(_portfolio == null)
                _portfolio = new List<Portfolio>();

            _portfolio.Add(item);
        }
    }

}
