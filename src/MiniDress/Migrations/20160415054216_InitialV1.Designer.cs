using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using MiniDress.Models;

namespace MiniDress.Migrations
{
    [DbContext(typeof(MiniDressContext))]
    [Migration("20160415054216_InitialV1")]
    partial class InitialV1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MiniDress.Models.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedTime");

                    b.Property<string>("GuestEmail");

                    b.Property<string>("GuestIpAddress");

                    b.Property<string>("GuestName");

                    b.Property<string>("GuestPhone");

                    b.Property<string>("ShippingAddr1");

                    b.Property<string>("ShippingAddr2");

                    b.Property<string>("ShippingCity");

                    b.Property<decimal?>("ShippingCost");

                    b.Property<string>("ShippingCountry");

                    b.Property<string>("ShippingPostalCode");

                    b.Property<string>("ShippingState");

                    b.Property<decimal?>("SubTotal");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("MiniDress.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("OrderId");

                    b.Property<long?>("ProductId");

                    b.Property<int?>("Quantity");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("MiniDress.Models.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<double>("Discount");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("MiniDress.Models.OrderItem", b =>
                {
                    b.HasOne("MiniDress.Models.Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("MiniDress.Models.Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
        }
    }
}
