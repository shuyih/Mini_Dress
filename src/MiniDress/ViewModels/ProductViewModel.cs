using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniDress.ViewModels
{
    public class ProductViewModel
    {
        [Required]
        public long Id { get; set; }
        public string Name { get; set; }                       
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public string Image { get; set; }
        public double? Discount { get; set; }

        public IEnumerable<OrderItemViewModel> OrderItems { get; set; }
    }
}
