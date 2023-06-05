using Final_Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using Final_Business;
using Final_Repository;

namespace Final_Api 
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase 
    {
        private readonly ILogger<StoreController> _logger;

        public StoreController(ILogger<StoreController> logger)
        {
            _logger = logger;
        }

        [HttpGet("greet")]
        public string Greet()
        {
            return "greet";
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegDto model)
        {
            if (!ModelState.IsValid)
            {
                ServiceBusinessLayer rpsb = new ServiceBusinessLayer();

                Person ret = rpsb.Register(model);
            }

            // Perform registration logic
            var person = new Person
            {
                UserName = model.UserName,
                Email = model.Email,
                // Hash and store the password securely
                Password = model.Password
            };

            return BadRequest (new {Message = "An error occurred:"});

        }

        [HttpPost("login")]
        public ActionResult<Person> Login(string username, string password = "no password sent. :(")
        {
             ServiceBusinessLayer rpsb = new ServiceBusinessLayer();
             Person p = rpsb.Login(username, password);

            

            // Perform login logic

            if (p == null )
            {
                return Unauthorized("Invalid username or password. Try Again");
            }

            return Ok(p);        
        }
        
    [HttpGet("stores-selection")] 
    public ActionResult<List<Store>> StoreSelection()
    {
        ServiceBusinessLayer rpsb = new ServiceBusinessLayer();

        // logic to retrieve and return stores
        List<Store> stores = rpsb.GetStores();

         if (stores != null) return Ok(stores);
            else return StatusCode(422, new { message = "An error occurred while retrieving stores. Please try again." });
        }

     [HttpGet("product-listing/{storeId}")]
public ActionResult<List<Product>> ProductListing(int storeId)
{
    try
    {
        ServiceBusinessLayer rpsb = new ServiceBusinessLayer();
        List<Product> products = rpsb.GetProductsByStoreId(storeId);

        if (products != null)
        {
            return Ok(products);
        }
        else
        {
            return StatusCode(422, new { message = "An error occurred while retrieving products. Please try again." });
        }
    }
    catch (Exception ex)
    {
        return StatusCode(500, $"An error occurred: {ex.Message}");
    }
}

    }
}  



