using System;
using System.Collections.Generic;

namespace MiniDress.Models
{
    public class Order
    {
        public long Id { get; set; }
        public string GuestName { get; set; }
        public string GuestEmail { get; set; }
        public string GuestPhone { get; set; }
        public string GuestIpAddress { get; set; }
        public string ShippingAddr1 { get; set; }
        public string ShippingAddr2 { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingCountry { get; set; }
        public decimal? ShippingCost { get; set; }
        public decimal? SubTotal { get; set; }
        public DateTime? CreatedTime { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
