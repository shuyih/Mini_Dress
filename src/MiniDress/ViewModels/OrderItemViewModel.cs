using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MiniDress.ViewModels
{
    public class OrderItemViewModel
    {
        public int Id { get; set; }
        public long? ProductId { get; set; }
        public int? Quantity { get; set; }
        public int OrderId { get; set; }
        public OrderViewModel Order { get; set; }
        public ProductViewModel Product { get; set; }
    }
}