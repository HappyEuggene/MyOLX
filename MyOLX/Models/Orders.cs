namespace MyOLX.Models
{
    public class Orders
    {
        public int Id { get; set; } 

        public int PaymentId { get; set; }

        public Payment? Payment { get; set; }

        public int DeliveryId { get; set; } 

        public Delivery? Delivery { get; set; }

        public List<Product> Products { get; set; } = new List<Product>(); 
        public string UserId { get; set; }



    }
}
