using System.Collections.Generic;

namespace Charme.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<string>? ListaDescription { get; set; }
    }
}