﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MiniDressEntities : DbContext
    {
        public MiniDressEntities()
            : base("name=MiniDressEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    
        public virtual int usp_CreateOrder(ObjectParameter id, string guestName, string guestEmail, string guestPhone, string guestIpAddress, string shippingAddr1, string shippingAddr2, string shippingCity, string shippingState, string shippingPostalCode, string shippingCountry)
        {
            var guestNameParameter = guestName != null ?
                new ObjectParameter("GuestName", guestName) :
                new ObjectParameter("GuestName", typeof(string));
    
            var guestEmailParameter = guestEmail != null ?
                new ObjectParameter("GuestEmail", guestEmail) :
                new ObjectParameter("GuestEmail", typeof(string));
    
            var guestPhoneParameter = guestPhone != null ?
                new ObjectParameter("GuestPhone", guestPhone) :
                new ObjectParameter("GuestPhone", typeof(string));
    
            var guestIpAddressParameter = guestIpAddress != null ?
                new ObjectParameter("GuestIpAddress", guestIpAddress) :
                new ObjectParameter("GuestIpAddress", typeof(string));
    
            var shippingAddr1Parameter = shippingAddr1 != null ?
                new ObjectParameter("ShippingAddr1", shippingAddr1) :
                new ObjectParameter("ShippingAddr1", typeof(string));
    
            var shippingAddr2Parameter = shippingAddr2 != null ?
                new ObjectParameter("ShippingAddr2", shippingAddr2) :
                new ObjectParameter("ShippingAddr2", typeof(string));
    
            var shippingCityParameter = shippingCity != null ?
                new ObjectParameter("ShippingCity", shippingCity) :
                new ObjectParameter("ShippingCity", typeof(string));
    
            var shippingStateParameter = shippingState != null ?
                new ObjectParameter("ShippingState", shippingState) :
                new ObjectParameter("ShippingState", typeof(string));
    
            var shippingPostalCodeParameter = shippingPostalCode != null ?
                new ObjectParameter("ShippingPostalCode", shippingPostalCode) :
                new ObjectParameter("ShippingPostalCode", typeof(string));
    
            var shippingCountryParameter = shippingCountry != null ?
                new ObjectParameter("ShippingCountry", shippingCountry) :
                new ObjectParameter("ShippingCountry", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_CreateOrder", id, guestNameParameter, guestEmailParameter, guestPhoneParameter, guestIpAddressParameter, shippingAddr1Parameter, shippingAddr2Parameter, shippingCityParameter, shippingStateParameter, shippingPostalCodeParameter, shippingCountryParameter);
        }
    
        public virtual ObjectResult<usp_GetProducts_Result> usp_GetProducts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetProducts_Result>("usp_GetProducts");
        }
    
        public virtual int usp_InsertOrderItem(ObjectParameter id, Nullable<long> productId, Nullable<int> quantity, Nullable<long> orderId)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(long));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            var orderIdParameter = orderId.HasValue ?
                new ObjectParameter("OrderId", orderId) :
                new ObjectParameter("OrderId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertOrderItem", id, productIdParameter, quantityParameter, orderIdParameter);
        }
    }
}
