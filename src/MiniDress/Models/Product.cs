using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MiniDress.Models
{
    public class Product
    {
        public Product()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public string Image { get; set; }
        public double? Discount { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

        public void Load(SqlDataReader reader)
        {
            Id = (long)reader["Id"];
            Name = reader["Name"].ToString();
            Description = reader["Description"].ToString();
            if (!string.IsNullOrEmpty(reader["Price"].ToString()))
            {
                Price = (decimal)reader["Price"];
            }
            Image = reader["Image"].ToString();
            if (!string.IsNullOrEmpty(reader["Discount"].ToString()))
            {
                Discount = (double)reader["Discount"];
            }
        }
    }
}
