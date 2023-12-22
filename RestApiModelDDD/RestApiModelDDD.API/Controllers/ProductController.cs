using Microsoft.AspNetCore.Mvc;
using RestApiModelDDD.Application.DTOs;
using RestApiModelDDD.Application.Interfaces;
using System;

namespace RestApiModelDDD.API.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IApplicationServiceProduct _applicationServiceProduct;

        public ProductController(IApplicationServiceProduct applicationServiceProduct)
        {
            _applicationServiceProduct = applicationServiceProduct;
        }

        [HttpGet("v1/products")]
        public IActionResult GetAll()
            => Ok(_applicationServiceProduct.GetAll());


        [HttpGet("v1/products/{id:int}")]
        public IActionResult GetById(
            [FromRoute] int id)
        {
            var product = _applicationServiceProduct.GetById(id);

            if (product == null)
                return NotFound("Not found");

            return Ok(product);
        }


        [HttpPost("v1/products")]
        public IActionResult Add(
            [FromBody] ProductDto model)
        {
            try
            {
                if (model == null)
                    return NotFound();

                _applicationServiceProduct.Add(model);

                return Ok(new { message = "Insertion successfull" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("v1/products")]
        public IActionResult Update(
            [FromBody] ProductDto model
        )
        {
            try
            {
                if (model == null)
                    return NotFound();

                _applicationServiceProduct.Update(model);

                return Ok(new { message = "Update successfull" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("v1/products")]
        public IActionResult Remove(
            [FromBody] ProductDto model)
        {
            try
            {
                if (model == null)
                    return NotFound();

                _applicationServiceProduct.Remove(model);

                return Ok(new { message = "Remove successfull" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
