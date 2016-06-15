using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper; 
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MiniDress.Models;
using MiniDress.ViewModels; 
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.PlatformAbstractions;

namespace MiniDress.Controllers
{
    public class ProductsController : Controller
    {
        private MiniDressContext _context;

        public ProductsController(MiniDressContext context)
        {
            _context = context; 
        }

        public IActionResult Index()
        {
            //var products = _context.Products.OrderBy(t=>t.Name).ToList();
            //var orders = _context.Orders.OrderBy(t => t.Id).ToList();
            //var orderItems = _context.OrderItems.OrderBy(t => t.Id).ToList();            

            return View();
        }

        public IActionResult Cart()
        {
            return View(); 
        }

        [HttpGet]
        public JsonResult GetProducts()
        {
            var products = _context.Products.OrderBy(t => t.Id).ToList();
            var results = Mapper.Map<IEnumerable<ProductViewModel>>(products); 
            return Json(results); 
        }

        [HttpGet]
        public JsonResult GetProduct(int id)
        {
            var product = _context.Products
                            .Where(t => t.Id == id)
                           .FirstOrDefault();            
            return Json(Mapper.Map<ProductViewModel>(product));
        }

        //Repositories
        private List<Product> GetProductList()
        {
            var connStr = Startup.Configuration["Data:DefaultConnection:ConnectionString"];
            var products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    var command = conn.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "usp_GetProducts";
                    var reader = command.ExecuteReader();

                    var product = new Product();
                    while (reader.Read())
                    {
                        product.Load(reader);
                        products.Add(product);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Data);
                }
            }
            return products;
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Details(int productId)
        {            
            return View();
        }
    }
}
