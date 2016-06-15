namespace MiniDress.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public long? ProductId { get; set; }        
        public int? Quantity { get; set; }
        public long? OrderId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
