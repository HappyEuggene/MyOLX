namespace MyOLX.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }

        public int CategoryId { get; set; }

        public Categories? Categories { get; set; }

        public List <Orders>? Orders { get; set; } = new List<Orders>();


    }
}
