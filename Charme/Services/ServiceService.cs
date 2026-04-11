using System.Collections.Generic;
using System.Linq;
using Charme.Models;

namespace Charme.Services
{
    public class ServiceService
    {
        private readonly List<Service> _services = new()
        {
            new Service { Id = 1, Name = "Corte de cabelo", Description = "Corte masculino e Feminino" },
            new Service { Id = 2, Name = "Manicure", Description = "Manicure profissional" }
        };

        public List<Service> GetServices() => _services;

        public Service AddService(Service service)
        {
            var nextId = _services.Count == 0 ? 1 : _services.Max(s => s.Id) + 1;
            service.Id = nextId;
            _services.Add(service);
            return service;
        }

        public Service? UpdateService(int id, Service service)
        {
            var existing = _services.FirstOrDefault(s => s.Id == id);
            if (existing == null) return null;

            existing.Name = service.Name;
            existing.Description = service.Description;
            return existing;
        }

        public bool DeleteService(int id)
        {
            var existing = _services.FirstOrDefault(s => s.Id == id);
            if (existing == null) return false;

            _services.Remove(existing);
            return true;
        }
    }
}
