using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiInvoince.WebApi.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        [HttpGet("/")]
        public string Get()
        {
            return "{\"status\":\"ok\"}";
        }

        [HttpPost("/{id}")]
        public string Post(string id)
        { 
            return "{\"status\":\"ok\"}";
        }
    }
}