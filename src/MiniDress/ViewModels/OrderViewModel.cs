using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniDress.ViewModels
{
    public class OrderViewModel
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
        public IEnumerable<OrderItemViewModel> OrderItems { get; set; }
    }
}
