using BasicProductsService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BasicProductsService.Controllers
{
   
    [Produces("application/json")]
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        static List<Product> products = new List<Product>()
        {
                new Product {Id = 0, Name = "Tomato Soup", Category = "Groceries", Price = 1},
                new Product {Id = 1, Name = "Yo-yo", Category = "Toys", Price = 3.75M},
                new Product {Id = 2, Name = "Hammer", Category = "Hardware", Price = 16.99M}
        };
        
       
  

        // GET: api/Products
        [HttpGet]
        public List<Product> Get()
        {
            
            return products;
        }

        // GET: api/Products/5
        [HttpGet("{id}", Name = "Get")]
        public Product Get(int id)
        {
          

            return (Product)products[id];
        }

        // POST: api/Products
        [HttpPost]
        public void Post([FromBody]Product value)
        {

            products.Add(value);
   

        }
        
        // PUT: api/Products/5
        [HttpPut("{id}")]
        public Product Put(int id, [FromBody]Product value)
        {
            products[id] = value;

            return value;

        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            products.RemoveAt(id);

        }
    }
}
