using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiInvoice.Application.Interfaces;
using WebApiInvoice.Domain.Models;

namespace WebApiInvoince.WebApi.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            return _service.SelectAll();
        }

        /// <summary>
        /// Obtener un producto x id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        public IActionResult GetById(int id)
        {
            return new OkObjectResult(_service.SelectById(id));
        }

        [HttpPost]
        [ProducesResponseType(typeof(Product), StatusCodes.Status201Created)]
        public IActionResult CreateProduct(Product product)
        {
            return new CreatedResult("default", _service.Add(product));
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteProduct(int id)
        {
            return new OkObjectResult(_service.Delete(id));
        }

        [HttpPut]
        [ProducesResponseType(typeof(bool),StatusCodes.Status200OK)]
        public IActionResult UpdateProduct (Product model)
        {
            return new OkObjectResult(_service.Update( model));
        }
    }
}