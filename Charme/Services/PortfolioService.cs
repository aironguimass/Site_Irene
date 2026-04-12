using Charme.Models;
using System.Collections.Generic;
using System.Linq;

namespace Charme.Services
{
    public class PortfolioService
    {
        private readonly List<Portfolio> _portfolio = new()
        {
            new Portfolio { Id = 1, Title = "Manicure", ImageUrl = "https://linkdafoto.com/unha1.jpg", Description = "Unha em gel com decoração floral" },
                    new Portfolio { Id = 2, Title = "Cabelo", ImageUrl = "https://linkdafoto.com/cabelo1.jpg", Description = "Corte feminino moderno" },
                    new Portfolio { Id = 3, Title = "Pedicure", ImageUrl = "https://linkdafoto.com/unha2.jpg", Description = "Unha porcelana clássica" }

        };

        public List<Portfolio> GetPortfolio() => _portfolio;//vai ler a lista

        

        public Portfolio AddPortfolioItem(Portfolio item)
        {
        var nextId = _portfolio.Count == 0 ? 1 : _portfolio.Max(p => p.Id) + 1;
            item.Id = nextId;
            _portfolio.Add(item);
            return item;
        }

        public Portfolio? UpdatePortfolioItem (int id, Portfolio item)
        {
            var existing = _portfolio.FirstOrDefault(p => p.Id == id);
            if (existing == null)return null;

            existing.Title = item.Title;
            existing.Description = item.Description;
            existing.ImageUrl = item.ImageUrl;
            return existing;

        }

        public bool DeletePortfolioItem(int id)
        {
            var existing = _portfolio.FirstOrDefault(p=> p.Id == id);
            if (existing == null)return false;

            _portfolio.Remove(existing);
            return true;
        }
    }

}
