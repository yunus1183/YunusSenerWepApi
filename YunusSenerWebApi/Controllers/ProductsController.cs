using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YunusSenerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService productService;
        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = productService.Add(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest();
        }

        [HttpPost("delete")]
        public IActionResult Delete(Product product)
        {
            var result = productService.Delete(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest();
        }

        [HttpPost("update")]
        public IActionResult Update(Product product)
        {
            var result = productService.Update(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest();
        }
        [HttpPost("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = productService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = productService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }
    }
}
