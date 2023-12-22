using System;
using Microsoft.AspNetCore.Mvc;
using RestApiModelDDD.Application.DTOs;
using RestApiModelDDD.Application.Interfaces;


namespace RestApiModelDDD.API.Controllers
{
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IApplicationServiceClient _applicationServiceClient;

        public ClientController(IApplicationServiceClient applicationServiceClient)
        {
            _applicationServiceClient = applicationServiceClient;
        }

        [HttpGet("v1/clients")]
        public IActionResult GetAll()
            => Ok(_applicationServiceClient.GetAll());


        [HttpGet("v1/clients/{id:int}")]
        public IActionResult GetById(
            [FromRoute] int id)
        {
            var client = _applicationServiceClient.GetById(id);

            if (client == null)
                return NotFound("Not found");

            return Ok(client);
        }


        [HttpPost("v1/clients")]
        public IActionResult Add(
            [FromBody] ClientDto model)
        {
            try
            {
                if (model == null)
                    return NotFound();

                _applicationServiceClient.Add(model);

                return Ok(new { message = "Insertion successfull" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("v1/clients")]
        public IActionResult Update(
            [FromBody] ClientDto model
        )
        {
            try
            {
                if (model == null)
                    return NotFound();

                _applicationServiceClient.Update(model);

                return Ok(new { message = "Update successfull" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("v1/clients")]
        public IActionResult Remove(
            [FromBody] ClientDto model)
        {
            try
            {
                if (model == null)
                    return NotFound();

                _applicationServiceClient.Remove(model);

                return Ok(new { message = "Remove successfull" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
