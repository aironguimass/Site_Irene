using System.Collections.Generic;
using Charme.Models;
namespace Charme.Services
{
    public class ServiceService
    {
        public List<Service> GetServices()
        {
            return new List <Service>
                {
                new Service {Id = 1, Name = "Corte de cabelo", Description = "Corte masculino e Feminino"},
                new Service { Id = 2, Name = "Manicure", Description = "Manicure profissional" }
            };
        }

        //POST PARA BUSCAR NO BANCO 
        public Service AddService(Service service)
        {
            return service;
        }
    }
}
