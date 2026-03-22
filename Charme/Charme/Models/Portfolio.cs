namespace Charme.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Title { get; set; } //define o tipo de serviço (ex: manicure, pedicure, cabelo)
        public string ImageUrl { get; set; }
        public string Description { get; set; }

    }
}
